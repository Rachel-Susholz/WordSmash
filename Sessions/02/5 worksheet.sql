--WorldRecord
--1 show all for USA that where acheived in the first two decades of the 21st century
select * from WorldRecord w where w.Country = 'usa' and w.YearAchieved between 2000 and 2019
--2 show all that category starts with a letters from A to D
select * from WorldRecord w where w.Category >= 'a' and w.Category < 'e'
--3 show all that country is United Kingdom or country contains j
select * from WorldRecord w where w.Country = 'united kingdom' or w.country like '%j%'
/*4
show all for USA or United Kindom that category is either Technology or Transportation, sort it by category then by country, 
show the columns Category, Country, Record Name, Amount, and Unit of Measure
*/
select w.Category, w.Country, w.RecordName, w.Amount, w.UnitOfMeasure from WorldRecord w where w.Country in ('USA','United Kingdom') and w.Category in ('technology','transportation') order by w.Category, w.Country