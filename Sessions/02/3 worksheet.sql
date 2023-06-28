use RecordKeeperDB
go
--WorldRecord
--1 show all that category begins with A
select * from WorldRecord w where w.Category like 'a%' 
--2 show all that category end with E
select * from WorldRecord w where w.Category like '%e'
--3 show all that Record Name contains oo (like the word boot or foot)
select * from WorldRecord w where w.RecordName like '%oo%'
--4 show all that Record Name does not contains oo
select * from WorldRecord w where w.RecordName not like '%oo%'
--5 show all that Record Name begins with Large
select * from WorldRecord w where w.RecordName like 'large%'
--6 show all that Record Desc contains Large
select * from WorldRecord w where w.RecordDesc like '%large%'
--7 show all that contains the words ice cream (there should be 2)
select * from worldrecord w where w.RecordDesc like '%ice%cream%'
