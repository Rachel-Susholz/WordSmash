--1 Bring the president table up to date, insert all missing presidents and information. (yeah, this is an "insert" on the "update" sheet)
insert president (Num, FirstName, LastName, Party, YearBorn, YearDied, TermStart, TermEnd)
select 45, 'Donald John', 'Trump', 'Republican', 1946, null, 2017, 2021
union select 46, 'Joseph Robinette', 'Biden', 'Democratic', 1942, null, 2021, null 
--1b Copy the insert statement from the above question to the bottom of "president 2 data.sql" so that you will have the missing data when data is reinserted.

--2 Correct the historical record, give president 44 his middle name.
Update p
set FirstName = p.FirstName + ' Hussein'
--select * 
from president p 
where p.Num = 44
--3 Change the name of these political parties to their colors; Republican = red, Democrat = blue.
update p
set Party = 'red'
--select * 
from president p 
where p.Party = 'Republican'

Update p
set Party = 'blue' 
--select *
from president p 
where p.Party = 'Democrat'
--4 The current president has been impeached. End his term in the current year.
update p
set TermEnd = 2023 
--select * 
from president p 
where p.Num = 46
--5 In 1845, the Whig party changed its name to the 'Whig Freedom' Party. Fix any presidents' data that has been affected by this change.
update p
set Party = 'Whig Freedom'
--select * 
from president p 
where p.Party = 'Whig' 
and p.TermStart >= 1845


