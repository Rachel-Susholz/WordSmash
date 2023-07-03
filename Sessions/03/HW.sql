--AS Amazing job! 100% Please see one comment, no need to resubmit.
--Medalist

/* 1
An Olympic medalist would like to sue the International Olympic Committee because she was unable to claim her medal and prize money. 
After thoroughly investigating the matter, we discovered that there was a bug in our system.  
The bug caused that France was not able to distribute a medal to any of its Olympians that have 'S' as the second letter in their Medalist code. 
Show the medalist that is suing the Olympic Committee.

*/
select * 
from medalist m 
where m.Country = 'France'
and m.Code like '_s%'

/* 2 
In the year 2000 a debate rose up among the Medalists of Scandinavia (Norway, Sweden, Finland and Denmark). 
Norway claimed to have outdone the others over the past 100 years. Norway claims that they have been the leading country in producing Medalists throughout that time. 
Swedish pundits responded that in the years 1965 - 1975 they had outperformed Norway, 
and that Norway has not produced any Olympians for the Summer season since 1913. 
A) Show all the Scandinavian medals for the time period that Norway has their claim. Sort by country and Year. Show columns: Country, Olympic Year 
B) Show the data that supports\refutes the claim of the Swedish pundits. Sort by Year, Country, Season. Show columns Year, Country, Season
For B) Use only one select statement that will show all this info (you will need nested parenthesis). 
*/
-- A)
select m.Country, m.OlympicYear 
from medalist m 
where m.Country in ('Norway', 'Sweden', 'Finland', 'Denmark')
and m.OlympicYear between 1900 and 2000
order by m.Country, m.OlympicYear
-- B)
select m.OlympicYear, m.Country, m.Season 
from Medalist m
where
(
--AS Norway and Sweden should be on both parts of the where clause instead of repeating it twice. The data is showing norway vs sweden so you can
-- include sweden in the result set.
    (m.Country in ('Norway', 'Sweden') and m.OlympicYear between 1965 and 1975) 
--AS The claim should only be until 2000, ie: 1913 - 2000
    or (m.Country = 'Norway' and m.Season = 'summer'and m.OlympicYear > 1913)
)
order by m.OlympicYear, m.Country, m.Season
/* 3
Olympic planning committee wants know whether or not it is common that candidates will participate in Olympics that take place in their own country or would travel to another country. 
Show 2 lists for the winter season. 
1) Candidates that participated in their own country 
2) Candidates that participated outside of their country
Show columns: First Name, Last Name, Country, Olympic Location, Season. Sort by medalist's Country, Olympic location.
*/
-- 1)
select  m.FirstName, m.LastName, m.Country, m.OlympicLocation, m.Season
from Medalist m 
where m.OlympicLocation like '%' + m.Country + '%'
order by m.Country, m.OlympicLocation
-- 2)
select m.FirstName, m.LastName, m.Country, m.OlympicLocation, m.Season 
from medalist m 
where m.OlympicLocation not like '%' + m.Country + '%'
order by m.Country, m.OlympicLocation
/* 4
In 1930 the Olympic organization received a complaint from a feminist group claiming that they were not being treated equally
since in the past 20 years there were no gold or silver medals awarded for sports categorized specifically for females.
Another complaint was that in the upcoming olympic of 1932, only one female's sport was scheduled.

Show the data that would support or disprove their claim, in one result set. Show columns Year, Sport subcategory, medal
*/
select m.OlympicYear, m.SportSubcategory, m.Medal 
from medalist m
where 
(
    m.SportSubcategory like '%ladies%' 
    or m.SportSubcategory like '%women%'
)
and
(
    (m.OlympicYear between 1910 and 1930 
    and m.Medal in ('silver','gold'))
or
    m.OlympicYear = 1932
)


/* 5
The organizers of the Olympics in Salt Lake City are analyzing the age of medalists per medal type in their skiing competitions. 
Provide a list of medalists, include only columns Sport, Age of medalist, Medal type, Last Name for the data they are analyzing.
Sort by Age and then by medal type.
*/
select m.sport, AgeofMedalist = m.OlympicYear - m.YearBorn, m.Medal, m.LastName
from medalist m
where m.OlympicLocation like '%Salt Lake City%'
and m.Sport like '%skiing%'  
order by AgeofMedalist, m.Medal
/*6
We need a list of medalists that participated in a sport category that has a possesive S (that the apostrophe follows the S like in Mens' Skating). 
Please provide 2 lists 1) The sub category ends with the possesive s (Mens') 
                       2) the subcategory contains it but does not end with it
*/
-- 1)
select * 
from medalist m 
where m.SportSubcategory like '%s'''
-- 2)
select *
from medalist m 
--AS Add an _ after the '' since we only want those that contain a possesive s in the middle of their name, not at the end.
where m.SportSubcategory like '%s''%'





