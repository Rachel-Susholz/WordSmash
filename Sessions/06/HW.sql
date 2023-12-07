--AS Great job! 95% Please see comments and resubmit.
-- All Columns should have Column Names unless otherwise specified

/*1. 
	The Olympic Committee has decided to give a special award to all gold medalists whose last name 
	begins with a 'P'. Show a list of these medalists and label them all as Category P
*/
select Category = 'P', m.Medal, m.LastName, * 
from Medalist m 
where m.Medal = 'gold'
and m.LastName like 'p%' 


 

/*2
	 Three new sports are being added into this year's Winter Olympic Competitions in Norway. Create 3 new sports from literal values,
	 show in one result set, leaving the MedalistId, medalist information and Code blank.
*/
--AS -5 olympiclocation = '%norway' will set it to be that literal value %norway instead of what you want. Rather give it its full value: Oslo, Norway.
select MedalistId = 0, OlympicYear = 2023, Season = 'winter', OlympicLocation = '%Norway', Sport = 'Alpine Jumping', SportSubcategory = 'Female Leauge', Medal = 'Silver', FirstName = '', LastName = '', Country = '', YearBorn = 0 , Code = '' 
from medalist m 
union select MedalistId = 0, OlympicYear = 2023, Season = 'winter', OlympicLocation = '%Norway', Sport = 'Alpine Sliding', SportSubcategory = 'Female Leauge', Medal = 'Bronze', FirstName = '', LastName = '', Country = '', YearBorn = 0, Code = '' 
from medalist m 
union select MedalistId = 0, OlympicYear = 2023, Season = 'winter', OlympicLocation = '%Norway', Sport = 'Speed Surfing' , SportSubcategory = 'Female Leauge', Medal = 'Bronze', FirstName = '', LastName = '', Country = '', YearBorn = 0, Code = '' 
from medalist m 
union select m.MedalistId, m.OlympicYear, m.Season, m.OlympicLocation, m.Sport, m.SportSubcategory, m.Medal, m.FirstName, m.LastName, m.Country, m.YearBorn, m.Code 
from medalist m 
where m.OlympicLocation like '%Norway'
and m.Season = 'winter'
/*3.
	A New Swimming Competition is being added into the upcoming Olympics. Specify the location and year.
	Show a list of all the past swimming winners with three blank rows 	as placeholders for the future ones.
	They should be blank, but should have the sport filled in as swimming.
*/
select MedalistId = 0, OlympicYear = 2023, Season = '', OlympicLocation = 'Greece', Sport = 'Swimming', SportSubcategory = '', Medal = '', FirstName = '', LastName = '', Country = '', YearBorn = 0, Code = '' 
union all select MedalistId = 0, OlympicYear = 2023, Season = '', OlympicLocation = 'Greece', Sport = 'Swimming', SportSubcategory = '', Medal = '', FirstName = '', LastName = '', Country = '', YearBorn = 0, Code = ''  
union all select MedalistId = 0, OlympicYear = 2023, Season = '', OlympicLocation = 'Greece', Sport = 'Swimming', SportSubcategory = '', Medal = '', FirstName = '', LastName = '', Country = '', YearBorn = 0, Code = '' 
union all select m.MedalistId, m.OlympicYear, m.Season, m.OlympicLocation, m.Sport, m.SportSubcategory, m.Medal, m.FirstName, m.LastName, m.Country, m.YearBorn, m.Code 
from Medalist m
where m.Sport = 'swimming'
/*4.
	Show a list of medalists and inventors in one result set for all born before the year 1900. 
	include the columns: Invention Name\Sport - Medal (like Swimming Gold ), First Name, Last Name, Year Born
	use generic names for the columns and add record type column at the beginning that says whether it is Medalist or Invention
	sort by record type, YearBorn
*/

select RecordType = 'Medalist', Record = m.sport + ' - ' + m.Medal, m.FirstName, m.LastName, m.YearBorn from Medalist m
union select RecordType = 'Invention', Record = i.InventionName, FirstName = i.InventorFirstName, LastName = i.InventorLastName, i.YearBorn 
from invention i
where YearBorn < 1900
order by RecordType, YearBorn

/*5
	Show a list of Silver medalists under the age of 25.
	2 Rows for each: 
		1. Description (Full Name and Country separated by a space), 
		2. Medal(Sport Medal and Country, eg Swimming Gold USA), both rows should have a medalist code columns
	Keep rows for each medal together

*/
select mDescription = m.FirstName + ' ' + m.LastName + ' ' + m.Country, m.Code, mSequence = 1, m.Medal 
from medalist m
where m.Medal = 'Silver'
and m.OlympicYear - m.YearBorn < 25
union select Medal = m.Sport + ' ' + m.Medal + ' ' + m.Country, m.Code, mSequence = 2, m.Medal 
from medalist m
where m.Medal = 'Silver'
and m.OlympicYear - m.YearBorn < 25
order by m.Code, mSequence






