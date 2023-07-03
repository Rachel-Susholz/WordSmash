--use long hand unless otherwise specified, do as select showing before and after, and then convert to update, after each question reinsert the original data

/*1
	You are a hacker, and "broke into" the RecordKeeper database. 
	Mess up the medalist data
	Set the age of all medalists to be 1 years old and set their Last Name to be their First Name, and set their First Name to be their Sport, and set Country to be Hackersland
*/
update m
set Age = 1, LastName = m.FirstName, FirstName = m.Sport, Country = 'Hackersland'
--select Age = m.OlympicYear - m.YearBorn, m.FirstName, m.LastName, m.Sport, m.Country, Age = 1, LastName = m.FirstName, FirstName = m.Sport, Country = 'Hackersland'
from medalist m 



/*2
	The Winter Olympics were too hot in France and Italy, change the Season to Fall when Olympic Location is in those countries.
*/
Update m
set Season = 'Fall'
--select m.Country, m.Season, Season = 'Fall'
from Medalist m 
where m.Country in ('France', 'Italy')
and m.Season = 'Winter'

/*3 
	Several complaints were filed with the Olympics Association, and they are making an effort to be politically correct. 
	Use as many statements needed to do the following.
	The International Shipping Association has protested that the sport Boxing reflects badly on their business. Change the sport to "Fist Combat"
	The World Bird Union complained about the use of Featherweight for boxing. Change that subcategory to "Not Heavyweight".
	The Union of Bronze Miners claims that the Olympics are unfairly depressing the price of Bronze. Change the "Bronze" medal to "Tin"
*/
update m
set Sport = 'First Combat'
--select m.Sport, Sport = 'First Combat' 
from Medalist m
where m.Sport = 'Boxing'

update m
set SportSubcategory = 'Not Heavyweight'
--select m.Sport, m.SportSubcategory, SportSubcategory = 'Not Heavyweight'
from Medalist m 
where m.Sport = 'Boxing'
and m.SportSubcategory = 'Featherweight'

update m
set Medal = 'Tin'
--select m.Medal, Medal = 'Tin'
from medalist m
where m.Medal = 'Bronze'
/*4
	It has been found that sport Trampoline has been rife with illegal drug use. Remove all trampoline records from the table. 
*/
delete m
--select m.Sport
from Medalist m
where m.Sport = 'Trampoline'

/*5
	The Grenada government has proven that:
		all Alpine skiers from 1936 to 1950 were Grenadian
		all Figure Skaters recorded as from Great Britain in 1924 and 1976 were actually Grenadian
	Grenada has been robbed of its glory. Correct the records.
*/
update m
set Country = 'Grenada'
--select m.Sport, m.Country, m.OlympicYear, Country = 'Grenada'
from Medalist m
where 
(
	m.Sport = 'Figure Skating'
 	and m.Country = 'Great Britain'
	and m.OlympicYear in (1924, 1976)
)
or 
(
	m.Sport = 'Alpine Skiing'
	and m.OlympicYear between 1936 and 1950
)