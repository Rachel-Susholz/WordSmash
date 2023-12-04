--ensure that all columns have column names
--1 produce 3 new inventions from literal values, show in one result set

--2 put two new inventions on top of a list of inventions, fill in only the invention name and leave the other columns blank or 0
select i.InventionId, i.InventionName, i.InventionDesc, i.YearInvented, i.InventorFirstName, i.InventorLastName, i.Country, i.YearBorn, i.YearDied, i.Code from invention i
union select InventionId = 0, InventionName = 'electric spider', InventionDesc = '', YearInvented = 0, InventorFirstName = '' , InventorLastName = '', Country = '', YearBorn = 0, YearDied = 0, Code = '' from invention i
union select InventionId = 0, InventionName = 'electric roach', InventionDesc = '', YearInvented = 0, InventorFirstName = '', InventorLastName = '', Country = '', YearBorn = 0, YearDied = 0, Code = '' from invention i
order by i.InventionId
--3 put two new rows on the of a list of inventions, the new rows should have the same invention name and all other columns blank

select InventionId = 0, InventionName = 'electric spider', InventionDesc = '', YearInvented = 0, InventorFirstName = '' , InventorLastName = '', Country = '', YearBorn = 0, YearDied = 0, Code = '' from invention i
union all select InventionId = 0, InventionName = 'electric spider', InventionDesc = '', YearInvented = 0, InventorFirstName = '', InventorLastName = '', Country = '', YearBorn = 0, YearDied = 0, Code = '' from invention i
union all select i.InventionId, i.InventionName, i.InventionDesc, i.YearInvented, i.InventorFirstName, i.InventorLastName, i.Country, i.YearBorn, i.YearDied, i.Code from invention i
order by InventionId
/*4 
	show list of inventions, each invention on 3 rows
	1st row = Invention Name, 2nd row = Inventor First and Last Name, 3rd row = Country
	each row should also have the invention code (note from editor: codes have been updated, disregard any differences you see)
	for each row add column that states which column it is
	Keep 1,2,3 together for each Invention
*/
select isequence = 1, What  = 'InventionName', i.InventionName, i.Code from Invention i
union select isequence = 2, What = 'InventorName', FullName = i.InventorFirstName + ' ' + i.InventorLastName, i.Code from Invention i
union select isequence = 3, What = 'InventionCountry', i.Country, i.Code from Invention i
order by i.Code