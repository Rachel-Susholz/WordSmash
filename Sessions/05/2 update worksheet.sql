--Invention, use long hand unless otherwise specified, do as select showing before and after, and then convert to update, after each question reinsert the original data

--1 using shorthand syntax extend the life of all the inventors. (add ten years to YearDied)
update Invention set YearDied = YearDied + 10
--2	update all USA inventors so they are 18 years old at the time of their invention, do not change Year Invented.
update i
set YearBorn = i.YearInvented - 18
select i.YearBorn, i.YearInvented, Age = i.YearInvented - i.YearBorn, YearBorn = i.YearInvented - 18 
from invention i
where i.Country = 'USA'
/*3
	there is some bad data where the invention was invented before the inventor was born, 
	in those cases change the year invented so that inventor was 90, and change data so that inventor died at 100
*/
update i
set YearInvented = i.YearBorn + 90, YearDied = i.YearBorn + 100
--select i.YearInvented, i.YearBorn, i.YearDied, AgeAtInvention = i.YearInvented - i.YearBorn, AgeAtDeath = i.YearDied - i.YearBorn , YearInvented = i.YearBorn + 90, YearDied = i.YearBorn + 100
from invention i 
where i.YearInvented < i.YearBorn
--4 change the invention name so it is in this format: Invention Name - Country. eg Dynamite - Sweden
update i
set InventionName = i.InventionName + ' - ' + i.Country
--select i.InventionName, i.Country, InventionName = i.InventionName + ' - ' + i.Country 
from Invention i

