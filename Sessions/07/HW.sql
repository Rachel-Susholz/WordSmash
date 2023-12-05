-- SM Excellent! 84% See comments, fix and resubmit.
/*
For all Questions use select insert unless otherwise specified.
When getting data from a source table always use the "source" data when you can, otherwise use literal values
*/

/* 1. 
      The Lahtela twin brothers both won medals for the Men's Moguls Freestyle Skiing competition in the 2002 Winter Olympics. 
      Janne's gold medal was entered into the database, but Jack's bronze medal was not. 
      Please add him in to correct this mistake. 
*/
-- SM -50% Take all data possible from table.
insert medalist(OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2002, 'winter', 'Athens, Greece', 'Skiing', 'Mens Moguls Freestyle', 'bronze', 'Jack', 'Lahtela', 'Austria', 1980
--2. For the year 2008; create a new sport, award medals for your new sport to the same medalists that won the 2008 Women's Trampoline sport.
-- SM -50% Same here.
insert medalist(OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2008, 'Winter', 'St. Moritz, Switzerland', 'Alpine Sliding', 'Womens', 'gold', 'Ekaterina', 'Khilko', 'Uzbekistan', 1982
union select 2008, 'Winter', 'St. Moritz, Switzerland', 'Alpine Sliding', 'Womens', 'Silver', 'He', 'Wenna', 'China', 1989
union select 2008, 'Winter', 'St. Moritz, Switzerland', 'Alpine Sliding', 'Womens', 'gold', 'Karen', 'Cockburn', 'Canada', 1980
/*3. 
      The Men's 200 Metres Swimming records were mistakenly left out of the 2000 Summer Olympic Games. 
      Add in the gold, silver and bronze medalists for it. 
      The good news is that it's the same exact winners as the Field High Jump! 
*/
-- SM Tip: Take the year, season, and location from the table. You only need to use literal values for sport and subcategory.
insert Medalist(OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2000, 'Summer', 'Athens, Greece', 'Swimming', 'Men''s 200 Metres Freestyle', m.Medal, m.FirstName, m.LastName, m.Country, m.YearBorn  
from Medalist m
where m.OlympicYear = 2000 
and m.Season = 'Summer'
and m.Sport = 'Field'
and m.SportSubcategory = 'High Jump'

--I got help with this question. However, I still don't understand it completely. Can you put notes as to why this question is answered with this code.
-- SM I assume you mean previous question. If yes, this makes me understand the problem with the first 2 questions.
-- The reason why this code works is, you select all data from table based on the info you get from question and you insert it to the table
-- The only things that you update is the columns that you don't select from table. You can insert as many rows you want. You just need to select that many rows.
-- You can either get the number of rows using a union select with literal values or you can get it by running a select statement and get back a results set with this number of rows.
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
