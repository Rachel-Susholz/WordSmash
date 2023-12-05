-- SM Excellent! 100% See comment, no need to resubmit.
/*
For all Questions use select insert unless otherwise specified.
When getting data from a source table always use the "source" data when you can, otherwise use literal values
*/

/* 1. 
      The Lahtela twin brothers both won medals for the Men's Moguls Freestyle Skiing competition in the 2002 Winter Olympics. 
      Janne's gold medal was entered into the database, but Jack's bronze medal was not. 
      Please add him in to correct this mistake. 
*/
-- SM Tip: Make sure to check on year, season and sport (and maybe also on medal)
insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn) 
select m.OlympicYear, m.Season, m.OlympicLocation, m.Sport, m.SportSubcategory, 'Bronze', 'Jack', m.LastName, m.Country, m.YearBorn 
from Medalist m 
where m.lastname = 'lahtela'
--2. For the year 2008; create a new sport, award medals for your new sport to the same medalists that won the 2008 Women's Trampoline sport.
insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select m.OlympicYear, m.Season, m.OlympicLocation, 'Alpine Sliding', 'Womens', m.Medal, m.FirstName, m.LastName, m.Country, m.YearBorn 
from Medalist m 
where m.OlympicYear = 2008 
and m.Sport = 'Trampoline' 
and m.SportSubcategory = 'Women''s'
/*3. 
      The Men's 200 Metres Swimming records were mistakenly left out of the 2000 Summer Olympic Games. 
      Add in the gold, silver and bronze medalists for it. 
      The good news is that it's the same exact winners as the Field High Jump! 
*/
insert Medalist(OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select m.OlympicYear, m.Season, m.OlympicLocation, 'Swimming' 'Men''s 200 Metres Freestyle', m.Medal, m.FirstName, m.LastName, m.Country, m.YearBorn  
from Medalist m
where m.OlympicYear = 2000 
and m.Season = 'Summer'
and m.Sport = 'Field' 
and m.SportSubcategory = 'High Jump'

/*4. 
     Add a new sport with new bronze, silver, and gold medalists for 2008. 
     Show two ways to do it. One with the values clause and one with the select statement.
*/
insert Medalist(OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
Values (2008, 'Summer', 'Athens, Greece', 'Alpine Sliding', 'Freestyle Sliding', 'Bronze', 'Rachel', 'Susholz', 'New York', 1990),
       (2008, 'Summer', 'Athens, Greece', 'Alpine Sliding', 'Freestyle Sliding', 'Gold', 'Sara', 'Smith', 'New York', 1991),
       (2008, 'Summer', 'Athens, Greece', 'Alpine Sliding', 'Freestyle Sliding', 'Silver', 'Rebecca', 'Brown', 'New York', 1992)

insert Medalist(OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2000, 'Summer', 'Athens, Greece', 'Alpine Sliding', 'Freestyle Sliding', 'Bronze', 'Rachel', 'Susholz', 'New York', 1990
union select 2000, 'Summer', 'Athens, Greece', 'Alpine Sliding', 'Freestyle Sliding', 'Gold', 'Sara', 'Smith', 'New York', 1991
union select 2000, 'Summer', 'Athens, Greece', 'Alpine Sliding', 'Freestyle Sliding', 'Silver', 'Rebecca', 'Brown', 'New York', 1992 


/*5
      A new Summer Olympic competition will be taking place in New York this year.
      It's the same sports and winners as the 2008 Summer Olympic in Beijing. 
      Add the records.
*/
insert Medalist(OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, 'Summer', 'New York, United States', m.Sport, m.SportSubcategory, m.Medal, m.FirstName, m.LastName, m.Country, m.YearBorn 
from Medalist m 
where m.OlympicYear = 2008
and m.OlympicLocation = 'Beijing, People''s Republic of China' 
and m.Season = 'Summer'
