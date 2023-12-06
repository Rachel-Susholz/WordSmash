-- SM Excellent! 100% See comments, no need to resubmit.
-- medalist
--For all updates do select first to check your work
--reinsert the data between questions if necessary
-- 1. Show list of medalist with score of how much their last name sounds like yours. Sort with the most similar at the top
-- SM Should be sorted by most similar on "top".
select m.LastName, SoundsLikeSusholz = difference(m.LastName, 'Susholz'), * 
from medalist m
order by SoundsLikeSusholz
/*
   2. Insert a new Winter Olympic Competition for the current year, all data based on the 2004 (note: use 2002 instead) Winter Olympics. 
      Reverse all the first and last names and replace all the 'a's' in the first names with 'w's'
*/
-- SM You should insert "all" data not just those that have an "a". Just replace the "a"s with w.
insert Medalist(OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn) 
select 2023, m.Season, m.OlympicLocation, 'Kick Boxing', 'Muscle Building', m.Medal, reverse(replace(m.FirstName,'a', 'w')), reverse(m.LastName), m.Country, m.YearBorn
from medalist m 
where m.OlympicYear = 2002
and m.Season = 'Winter'
and m.FirstName like '%a%'
/*
   3. We need to produce a report that has the Medalist in the following format.
      Format: First Initial of Medalist. Last Name - Medal in lowercase, Country in Uppercase: YearBorn (ex. S. Versis - bronze, GREECE: 1879)
      Show all medalists with this additional column.
*/
select Concat = concat(substring(m.FirstName, 1,1), '. ', m.LastName, ' - ', Lower(m.Medal), ', ', upper(m.Country), ': ', m.YearBorn), * 
from Medalist m 
 
/*
   4. You are going to hold RecordKeeper ransom by "encrypting" the medalist table. Encrypt it following the instructions below. 
Also prepare a decryption statement, so that when ransom is paid we can fix the data. Test the decryption statement to ensure that it works.
         1) Swap initials of first and last names. John Smith would become Sohn Jmith 
         2) Reverse Olympic Season, proper case it after being reversed
         3) Double the Olympic Year and then subtract 1 from it
         4) In Sport replace all letters, "a" with "*", "o" with "@"
*/
--encrypt 
-- SM Tip: Use concat(substring(),substring()).
update m 
set m.FirstName = substring(upper(m.LastName), 1, 1) + substring(lower(m.FirstName), 2, 100),
    m.LastName = substring(upper(m.FirstName), 1, 1) + substring(lower(m.LastName), 2, 100),
    m.Season = substring(reverse(upper(m.Season)), 1, 1) + substring(reverse(lower(m.Season)), 2, 100),
    m.OlympicYear = (m.OlympicYear * 2) - 1,
    m.Sport = replace(replace(m.sport, 'a', '*'), 'o', '@')
 --select FirstName = m.FirstName = substring(upper(m.LastName), 1, 1) + substring(lower(m.FirstName), 2, 100), 
 --LastName = substring(upper(m.FirstName), 1, 1) + substring(lower(m.LastName), 2, 100),    
 --ReverseOlympic = reverse(upper(m.Season), 1)) + substring(reverse(lower(m.Season)), 2, 100),
 --Yearx2MinusOne = (m.OlympicYear * 2) - 1,
 --ReplacedSport = replace(replace(m.sport, 'a', '*'), 'o', '@'), *  
from Medalist m 
select*from Medalist

--Decrypt
update m 
set m.FirstName = substring(upper(m.LastName), 1, 1) + substring(lower(m.FirstName), 2, 100),
    m.LastName = substring(upper(m.FirstName), 1, 1) + substring(lower(m.LastName), 2, 100),
    m.Season = substring(reverse(upper(m.Season)), 1, 1) + substring(reverse(lower(m.Season)), 2, 100),
    m.OlympicYear = (m.OlympicYear / 2) + 1,
    m.Sport = replace(replace(m.sport, '*', 'a'), '@', 'o')
 --select FirstName = substring(upper(m.LastName), 1, 1) + substring(lower(m.FirstName), 2, 100), 
 --LastName = substring(upper(m.FirstName), 1, 1) + substring(lower(m.LastName), 2, 100),
 --ReverseOlympic = reverse(right(upper(m.Season), 1)) + substring(reverse(lower(m.Season)), 2, 100),
 --Year/2PlusOne = (m.OlympicYear / 2) + 1,
 --ReplacedSport = replace(replace(m.sport, '*', 'a'), '@', 'o'), *  
from Medalist m 
/*
   5. Explore the Microsoft Docs, pick a string function that we did not learn. Write a question that exercises that function for the CPU staff to do. 
*/
select * from medalist m

--You are a Medalist Enthusiast and would like to have a seperate column that includes the first three letters of the medalists' lastnames for easy reference.
--Create the column and label it "Reference". Order by Reference.
select Reference = left(m.LastName,3), *
from Medalist m
order by Reference