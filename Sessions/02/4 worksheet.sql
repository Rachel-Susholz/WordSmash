use RecordKeeperDB
go
--Invention
--1 show all that Invention Name starts with Pho
select * from invention i where i.InventionName like 'pho%'
--2 show all that Invention Name contains pho
select * from invention i where i.InventionName like '%pho%'
--3 show all that Invention Name does not contain pho
select * from invention i where i.InventionName not like '%pho%'
--4 show all that Invention Desc contains mach
select * from Invention i where i.InventionDesc like '%mach%'
--5 show all that invention name contains an a and then z (does not have to be immediately after a)
select * from Invention i where i.InventionName like '&a&z&'
/*6
I am looking for all inventions that have some form of air based travel in its description. 
Can you show me all that have the words air and craft in their description. They may not be in one continuous word.
*/
select * from invention i where i.InventionDesc like '%air%craft%'