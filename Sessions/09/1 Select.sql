--The US Gov needs the following reports, please write the SQL that produces these reports.

--1 Show one result set including all presidents with a blank row on top. Only show columns Num, FirstName, LastName, Party; sort them by president number.
select Num = 0, FirstName = '', LastName = '', Party = ''
union select p.Num, p.FirstName, p.LastName, p.Party   
from president p 
order by Num
--2 Show all with a column for age at term start sorted by age and then Num. Arrange the columns so that "Age at start of term" is after TermStart.
select p.PresidentId, p.Num, p.FirstName, p.LastName, p.Party, p.YearBorn, p.YearDied, p.TermStart, AgeAtStartTerm = p.TermStart - p.YearBorn, p.TermEnd 
from president p
order by AgeAtStartTerm, p.Num 
--3 Show a list of presidents with their full name plus political party like this: Last Name, First Name (party). Do not include any other columns.
select FullName = p.LastName + ', ' + p.FirstName + ' (' + p.Party + ')'
from president p
--4 Show all presidents that took office under age 60, include age column.
select AgeAtStartTerm = TermStart - YearBorn, *  
from president p 
where p.TermStart - p.YearBorn < 60
--5 Show all with columns for age at time of begin term, end term, death, and how many years they served. If a president is still alive then show null for year died and death age.
select  AgeAtTermStart = p.TermStart - p.YearBorn, AgeAtTermEnd = p.TermEnd - p.YearBorn,
        AgeAtDeath = p.YearDied - p.YearBorn, YearsServed = p.TermEnd - p.TermStart, *
from president p 
--6 Show all non 'Democrat' presidents with an 'e' or 'p' in their first name.
select *
from president p 
where p.Party <> 'Democrat'
and p.FirstName like '%[ep]%'
--7 Show all presidents with last names: Adams, Clinton, or Bush; that were either over 55 at the start of their term or started their term in the 20th century.
select *
from president p 
where p.LastName in ('Adams', 'Clinton', 'Bush')
and 
(
   (p.TermStart - p.YearBorn > 55)
Or 
   (p.TermStart between 1901 and 2000)
)
--8 Show all presidents that died less than 60 years old, include age at death, and sort by party then by number of years served.
select AgeAtDeath = p.YearDied - p.YearBorn, YearsServed = p.TermEnd - p.TermStart, *  
from president p
where p.YearDied - p.YearBorn < 60 
order by p.Party, YearsServed
--9 Show all Democratic presidents who took office between the ages of 30 and 50, and Republican presidents who served more than one term, sorted by their parties.
select AgeAtTermStart = p.TermStart - p.YearBorn, TermsServed = (p.TermEnd - p.TermStart) / 4 , *
from president p 
where 
(
    p.Party = 'Democrat'
    and p.TermStart - p.YearBorn between 30 and 50
)
Or 
(
    p.Party = 'Republican'
    and p.TermEnd - p.TermStart > 4 
)
order by p.Party
--10 Show all living presidents, sorted by president number
select * 
from president p 
where p.YearDied is null
order by p.Num