-- SM Excellent! 80% See comments, fix and resubmit.
--1 show me all medals won in the summer season by Greek or Spanish medalists, sorted by sport and then year
-- SM Formatting tip: Each clause should be on new line
select * 
from Medalist m 
where m.Season = 'summer' 
and m.Country in ('Greece', 'Spain') 
order by m.Sport, m.OlympicYear
/*2
The Swiss government has requested a list of medalists from their country since 1928 who were over the age of 24 when they won their medal.
Include only First name, last name, age when they won the medal sorted by sport and sport category.
*/
-- SM Formatting tip: Each clause should be on new line
select m.FirstName, m.LastName, AgeWhenWonMedal = m.OlympicYear - m.YearBorn 
from Medalist m 
where m.Country = 'Switzerland'
and m.OlympicYear > 1928
and m.OlympicYear - m.YearBorn > 24
order by m.Sport, m.SportSubcategory
/*3
For all medalists that won a gold medal for a some sort of skating show their first name, last name, olympic location, sport and year.
Sort by year and sport.
*/
-- SM Formatting tip: Each clause should be on new line
-- You have a typo in your like statement so it doesn't return anything
select m.FirstName, m.LastName, m.OlympicLocation, m.Sport, m.OlympicYear 
from Medalist m 
where m.Medal = 'gold'
and m.Sport like '%skating%'
order by m.OlympicYear, m.Sport
/*4
There is some suspicion on certain medalists. 
A clue of foul play was found for silver and gold medalists under 30 years old with the letters "st" in their last name, followed by an "e", there may be other letters between "st" and "e".  
Provide the a list of medalists that match that clue, exclude the MedalistId, Code, and Year Born, include the age
Sort by age high to low, medal, last name
*/
-- SM Formatting tip: Each clause should be on new line
select AgeWhenWonMedal = m.OlympicYear - m.YearBorn, m.Country, m.FirstName, m.LastName, m.Medal, m.OlympicLocation, m.OlympicYear, m.Season, m.Sport, m.SportSubcategory 
from medalist m 
where m.Medal in ('silver','gold')
and m.OlympicYear - m.YearBorn < 30
and m.LastName like '%st%e%'
order by AgeWhenWonMedal desc, m.Medal, m.LastName
/*5
We need to produce a list of inventions that were either created for war or were invented because of a war. 
Can you produce a list of inventions that mention war in their description. 
Be careful not to include descriptions that have words like hardware or forward, but do include words that begin with war like warhead. 
We may get some that are not related, like if has "wart", that is fine, we will remove those manually (no pun intended)
*/
-- SM Formatting tip: Each clause should be on new line
-- This doesn't return anything.
select * 
from invention i 
where i.InventionDesc like '% war%'
