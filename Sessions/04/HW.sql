--For all questions do long-hand delete unless otherwise specified, first do as select and then delete, after each question re-insert the data

--1 Delete all medalist records using shorthand syntax
delete Medalist
--2 Delete all medalist records using longhand syntax
delete m from Medalist m
--3 In medalist delete all where age of medalist is less than 18 or over 60, in your select statement show the age
delete m 
--select AgeOfMedalist = m.OlympicYear - m.YearBorn
from medalist m
where (m.OlympicYear - m.YearBorn < 18 or m.OlympicYear - m.YearBorn > 60)

--4 In medalist delete all medalists with two last names, with or without a hyphen (Smith Jones or Smith-Jones). Only show the first and last name in your select statement. 
delete m
--select m.FirstName, m.LastName
from medalist m 
where (m.LastName like '% %' or m.LastName like '%-%')
and m.LastName not like '% % %'

