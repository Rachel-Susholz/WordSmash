--Invention 
--1 show all where invention name includes air or nuclear
select * from invention i where i.InventionName like '%air%' or i.InventionName like '%nuclear%'
--2 show all USA or France inventions that were invented in the 1800s, sort by country then be year invented high to low, do not show the Year Died or the Code
select i.Country, i.InventionDesc, i.InventionId, i.InventionName, i.InventorFirstName, i.InventorLastName, i.YearBorn, i.YearInvented from Invention i where i.Country in ('USA', 'France') and i.YearInvented between 1800 and 1899 order by i.Country, i.YearInvented desc
/*3 
show French or USA inventions where the inventor died less than 20 years after the invention, sort by year invented high to low, 
show how many years after the invention the inventor died
*/
select YearsDiedAfterInvention = i.YearDied - i.YearInvented, * from invention i where i.Country in ('USA', 'France') and i.YearDied - i.YearInvented < 20 order by i.YearInvented desc
