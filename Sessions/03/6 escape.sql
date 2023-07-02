--1 Show all world records where the record description includes its country in possessive form (China's rocket).
select *
from WorldRecord w 
where w.RecordDesc like '%' + w.Country + '''%'
--2 Show all world records where the record description includes quoted 'Gundam Global Challenge'
select *
from WorldRecord w 
where w.RecordDesc like '%''Gundam Global Challenge''%'
--3 Show all inventions that contain a [
select *
from invention i 
where i.InventionDesc like '%![%' escape '!'