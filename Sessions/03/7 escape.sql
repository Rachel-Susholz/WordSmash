--Inventions

--1 Show all where the invention description includes a possessive word ('s or s')
select *
from invention i 
where i.InventionDesc like '%''s%'
or i.InventionDesc like '%s''%'
--2 Show all where invention description includes a percentage less than 10%.
select *
from invention i 
where i.InventionDesc like '% [1-9]!%%' escape '!'
--3 Show all with more than 4 percentages in the invention description.
select *
from Invention i 
where i.InventionDesc like '%!%%!%%!%%!%%' escape '!'