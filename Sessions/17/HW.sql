--Do all work without dropping tables, and put your scripts in the table source code
-- Medalist

/* 1. The Olympic Committee would like to have a new column that stores the age of medalist at time they won the medal.
      Add in this column.
*/
alter table Medalist drop column if exists AgeAtTimeWon
go 
alter table Medalist add AgeAtTimeWon as OlympicYear - YearBorn persisted 

/* 2. A new column is required to display medalist information in a short summary.
      It should look like this: Medal - Medalist Initials: Olympic Year
      Example: Bronze - S.V.: 1896
*/
alter table Medalist drop column if exists MedalistInfo
go 
alter table Medalist add MedalistInfo as concat(Medal, ' - ', substring(FirstName,1,1), '.', substring(LastName,1,1), '.: ', OlympicYear) persisted
 
/* 3. The Olympic Committee would like a column that says if a medalist is a gold medalist or not.
      Create a new computed column, if the medal is gold than the value should be 1, otherwise it should be 0. 
*/
alter table Medalist drop column if exists AchievedGoldMedal
go 
alter table Medalist add AchievedGoldMedal as (case when medal = 'Gold' then 1 else 0 end) persisted

/* 4. The Olympic Committe wants to record the address of all medalists. 
      It should allow blanks in case an address is unknown but shouldn't allow nulls.
*/
alter table Medalist drop constraint if exists d_Medalist_Medalist_address
alter table Medalist drop column if exists MedalistAddress
go 
alter table Medalist add MedalistAddress varchar (50) not null constraint d_Medalist_medalist_address default ''

-- president
-- 5. Add a column called AgeAtDeath for each president
alter table President drop column if exists AgeAtDeath
go 
alter table President add AgeAtDeath as year(Datedied) - year(dateborn) persisted 

-- 6. Add a column called YearsServed for each president
alter table President drop column if exists YearsServed
go 
alter table President add YearsServed as TermEnd - TermStart persisted 

-- 7. Add a new column that displays the number of full terms served, zero is correct if served less than 4 years
alter table President drop column if exists TermsServed
go 
alter table President add TermsServed as (case when (TermEnd - Termstart) / 4 < 1 then 0 else (TermEnd - Termstart) / 4 end) persisted
-- RS How do I make sure that it only displays full terms and not let's say 1.5 for a president that served for 6 years?