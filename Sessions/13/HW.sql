--AS Amazing job! 100%
-- Medalist
/*1
The Olympic website is showcasing the history of Olympic games.
The web developer is asking for SQL statements that will provide the following lists.
*/
-- a. Show a list of the first ten years of Olympics played, show just the year
select distinct top 10 m.OlympicYear 
from medalist m
order by m.OlympicYear
-- b. List the first 10 olympic games, show their year, location, and season
select distinct top 10 m.Sport, m.OlympicYear, m.OlympicLocation, m.Season
from medalist m
order by m.OlympicYear
-- c. Show 5 sports and their subcategory that were played in France before 1950, include the location in the result set
select distinct top 5 m.Sport, m.SportSubcategory, m.OlympicLocation
from medalist m
where m.OlympicYear < 1950 
and m.OlympicLocation like '%France'
-- d. Show a list of the ten oldest athletes to win gold medals for sports Biathlon, Boxing, and Ski Jumping, the list should show name, age, and year born, sort by age and then by last name
select top 10 m.FirstName, m.LastName, Age = m.OlympicYear - m.YearBorn, m.YearBorn
from medalist m
where m.Medal = 'gold'
and m.Sport in ('Biathlon', 'Boxing', 'Ski Jumping')
order by Age desc, m.LastName
-- President
/*2. We are in middle of updating the U.S Government website and require some modifications to make it more modern looking.
The new graphic designer does not like the current list of presidents that shows null for living and current presidents.
Show a list of presidents, include all information. For null date died show a dash, otherwise show in format MM/DD/YYYY. 
For null term end show Current. Sort by Num descending
*/ 
Select DateDied = isnull(convert(varchar, p.DateDied, 101), '-'), TermEnd = isnull(convert(varchar, p.TermEnd), 'Current'), *
from president p
order by p.Num desc
--3 The new U.S Government website needs some new lists. Please provide the following data: 
--a List the 3 presidents that served the shortest term
select top 3 TermLen = p.TermEnd - p.TermStart, * 
from president p
where p.TermEnd is not null
order by TermLen
--b Show the top two parties with the most presidents. Show the party name and the number of presidents.
select top 2 AmntOfPres = count(p.Party), p.Party
from president p
group by p.Party
order by AmntOfPres desc
/*4. 
While the website was being worked on, security was not enforced and a hacker broke into the president table! 
As part of the investigation we need to reproduce the SQL statements that were used in the hack.
Write statments that do the following:
*/
--a Delete three republican presidents
delete top (3) p
from president p 
where p.Party = 'republican'
--b Delete 1 non-republican that served two terms after 1960
delete top (1) p 
from president p 
where p.Party <> 'republican'
and p.TermStart > 1960
and p.TermEnd - p.TermStart = 8
--c Reverse the last names of 7 presidents that lived before 1900
update top (7) p 
set LastName = reverse(p.lastname)
--select LastName = reverse(p.lastname)
from president p 
where year(DateDied) < 1900

