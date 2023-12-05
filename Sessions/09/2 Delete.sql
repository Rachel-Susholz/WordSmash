-- SM Excellent work! 100%
--re run the data file between questions
--1 Delete your least respected president from the table.
delete p
--select * 
from president p
where p.LastName = 'Obama'
--2 Delete presidents that did not complete a single term.
delete p
--select YearsServed = p.TermEnd - TermStart, *
from president p 
where p.TermEnd - p.TermStart < 4
--3 Delete presidents that served two complete terms and took office between the age of 35 and 50
delete p 
--select TermsServed = (p.TermEnd - p.TermStart) / 4 , AgeAtTermStart = p.TermStart - p.YearBorn, *
from president p 
where p.TermEnd - p.TermStart = 8
and p.TermStart - p.YearBorn between 35 and 50 
--4 Delete all presidents from the Whig party that either have a middle name or started their term under the age of 55.
delete p 
--select *
from president p 
where p.Party = 'Whig'
and 
(
    p.FirstName like '% %'
or
    p.TermStart - p.YearBorn < 55
)
