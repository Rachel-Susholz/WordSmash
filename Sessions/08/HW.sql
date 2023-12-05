-- SM Excellent work! 90% See comments, fix and resubmit.
-- Use the Medalist Table

/*
	1. The three winners of the 2008 Women's Swimming Competitions' registration papers got lost. 
	   Therefore, we don't know their country or the year that they were born in.
	   Please insert them regardless.
*/
-- SM Tip: No need for union "all". You have different data.
insert Medalist(OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2008, 'Summer', 'Athens, Greece', 'Swimming', 'Wommens Competitions', 'Gold', 'Sara', 'Smith', null, null
union all select 2008, 'Summer', 'Athens, Greece', 'Swimming', 'Wommens Competitions', 'Silver', 'Jaqueline', 'Green', null, null
union all select 2008, 'Summer', 'Athens, Greece', 'Swimming', 'Wommens Competitions', 'Bronze', 'Rachel', 'White', null, null 
-- 2. You are currently hacking the Olympic database. Wipe out the Year Born for any medalist who was under the age of 20 when they won their medal.
update m 
set m.YearBorn = null
--select Age = m.OlympicYear - m.YearBorn, * 
from medalist m 
where m.OlympicYear - m.YearBorn < 20
/* 
	3. The new King of Kenya is in middle of changing the name of his country. 
	   He has demanded to wipe out all traces of the name Kenya even though there is no new name yet. 
	   Please fulfill his request.
*/
update m 
set m.Country = null 
--select * 
from Medalist m
where m.Country = 'Kenya'
--4. Display the age for all American medalists when they won, order by YearBorn, excluding all medalists that don't have a Year Born recorded.
-- SM -50% Just display no delete. Display age for all "American" medalist, excluding those that don't have a year born.
select Age = m.OlympicYear - m.YearBorn, *
from medalist m
order by m.YearBorn

delete m 
from Medalist m 
where m.YearBorn is null
/*  
	5. The Olympic committee has just made a new rule: Any medalist without a country is invalid and will have their medal revoked.
	   Delete all medalists who do not have a country.
*/
delete m
--select *
from medalist m 
where m.Country is null