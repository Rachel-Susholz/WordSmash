-- lookup how to get the current date and time stamp and use it for the following questions:

--1) show the current date and time
select DateAndTime = GETDATE()

--2) in one result set show current day, month, year,second and millisecond
select DateAndTime = getdate()
--or
select DateAndTime = current_timestamp()

--3) in separate columns show how many milliseconds, seconds, minutes, hours, days ago you were born
select MillisecondsAgo = datediff_big(ms,'9/03/2003', current_timestamp), SecondsAgo = datediff_big(ss, '9/03/2003', current_timestamp),
 MinutesAgo = datediff_big(mi, '9/03/2003', current_timestamp), HoursAgo = datediff(hh, '9/03/2003', current_timestamp), DaysAgo = datediff(dd, '9/03/2003', current_timestamp)   

--4) add 1000 hours to now to see what date and time it will be
SELECT OneThousandHoursFromNow = dateadd(hour, 1000, current_timestamp) 

--president
/*5.
    Update the time of death for all presidents that do not have a precise DateDied recorded.
    Presidents whose last names start with A - L died at 7:42 pm.
    Presidents whose last names start with M - Z died at 11:02 am. 
*/
update p 
set p.DateDied = dateadd(hour, 19,dateadd(minute, 42, p.DateDied))
--select *
from president p 
where p.LastName like '[a-l]%'
and p.DateDied is not null

update p 
set p.DateDied = dateadd(hour, 11,dateadd(minute, 02, p.DateDied))
--select *
from president p 
where p.LastName like '[m-z]%'
and p.DateDied is not null

/*6. Bad data was inserted into the president table. A programmer mistakenly updated Ronald Reagan's first name to be his year born.
       1. Recreate this error
       2. A different programmer is trying to fix the data, but doesn't know which president has this issue. All he\she knows is that one president has a year instead 
          of text for his first name. Show how you would find the bad data and correct it.
*/
--1.
update p 
set p.FirstName = datepart(year,p.DateBorn)
--select * 
from president p
where p.FirstName = 'Ronald Wilson' and p.LastName = 'Reagan'

--2.
update p 
set p.FirstName = 'Ronald Wilson'
--select * 
from President p 
where isdate(p.FirstName) = 1 


-- medalist
/*7. The Olympic Committee wants to see a list of what dates the Olympics began on. Show in as many lists as required:
     From 1896 - 1950, Winter Olympics began on January 10 and Summer Olympics on June 20.
     From 1950 - Current, Winter Olympics began on February 9 and Summer Olympics on July 23.
*/
select OlympicDate = datefromparts(m.OlympicYear, 01, 10), * 
from Medalist m 
where m.OlympicYear between 1869 and 1950
and m.Season = 'winter'

select OlympicDate = datefromparts(m.OlympicYear, 06, 20), * 
from Medalist m 
where m.OlympicYear between 1869 and 1950
and m.Season = 'summer'

select OlympicDate = datefromparts(m.OlympicYear, 02, 09), * 
from Medalist m 
where m.OlympicYear between 1950 and 2023
and m.Season = 'winter'

select OlympicDate = datefromparts(m.OlympicYear, 07, 23), * 
from Medalist m 
where m.OlympicYear between 1950 and 2023
and m.Season = 'summer'

--8 Include the insert statement that was done to bring the president table up to date in the source code data, run the insert so that you have the latest
insert president(Num, FirstName, LastName, Party, DateBorn, DateDied, TermStart, TermEnd)
      select 45, 'Donald John', 'Trump', 'Republican', '1946-06-14', null, 2017, 2021
union select 46, 'Joseph Robinette', 'Biden', 'Democratic', '1942-11-20', null, 2021, null
 