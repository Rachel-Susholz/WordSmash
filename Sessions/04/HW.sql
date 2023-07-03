-- SM Excellent! You're missing one question. See comments, fix and resubmit.
--For all questions do long-hand delete unless otherwise specified, first do as select and then delete, after each question re-insert the data

--1 Delete all medalist records using shorthand syntax
delete Medalist
--2 Delete all medalist records using longhand syntax
delete m from Medalist m
--3 In medalist delete all where age of medalist is less than 18 or over 60, in your select statement show the age
-- SM Tip: Can use not between
delete m 
--select AgeOfMedalist = m.OlympicYear - m.YearBorn
from medalist m
where m.OlympicYear - m.YearBorn not between 18 and 60

--4 In medalist delete all medalists with two last names, with or without a hyphen (Smith Jones or Smith-Jones). Only show the first and last name in your select statement. 
-- SM Tip: Can use [] in like
delete m
--select m.FirstName, m.LastName
from medalist m 
where (m.LastName like '% %' or m.LastName like '%-%')
and m.LastName not like '% % %'

-- SM You're missing one question
/*5 
In invention delete all records where it is impossible that this inventor created this invention (based on year born or died). 
In select statement show columns in this order Invention Name, Inventor Last Name, Year Invented, Year Born, Year Died, Age at time of invention
*/
delete i
--select i.InventionName, i.InventorLastName, i.YearInvented, i.YearBorn, i.YearDied, AgeAtTimeOfInvention = i.YearInvented - i.YearBorn 
from invention i 
where i.YearBorn > i.YearInvented
or i.YearDied < i.YearInvented