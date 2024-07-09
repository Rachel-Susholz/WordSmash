
/* 1
Medalist 
   Recently somebody entered bad data into the medalist table (mixed up the year born and the olympic year),
   and that data was used to create an advertisement targeting an international audience.
   The advertisement was viewed by millions of people around the world. It was very embarassing.
   Strengthen the table in order to ensure that no bad data is ever inserted again.
   The following rules must be enforced:
      The year born must be before olympic year.
      The first olympic games happened in 1896. No data is allowed to be inserted before that.
      No null data is allowed.
      Columns should not allow blank data, zeros or negative numbers to be inserted. 
      Medalists must be at least 14 years old in order to compete in olympic games.
      Each olympic year and season can only have one of each medal for each sport and it's sport subcategory.
    After adding in the constraints, rerun the medalist data and include test scripts for the constraints to prove that you have succeeded in strengthening the table.
*/
use RecordKeeperDB
go 
drop table if exists Medalist
go
create table dbo.Medalist(
	MedalistId int not null identity primary key,
	OlympicYear int not null constraint ck_Medalist_olympic_year_must_be_greater_than_1895 check(OlympicYear >= 1896),
	Season varchar (50) not null constraint ck_Medalist_season_cannot_be_blank check(season <> ''),
	OlympicLocation varchar (100) not null constraint ck_Medalist_olympic_location_cannot_be_blank check(OlympicLocation <> ''),
	Sport varchar (100) not null constraint ck_Medalist_sport_cannot_be_blank check(sport <> ''),
	SportSubcategory varchar (100) not null constraint ck_Medalist_sport_subcategory_cannot_be_blank check(SportSubcategory <> ''),
	Medal varchar (6) not null constraint ck_Medalist_medal_cannot_be_blank check(Medal <> ''),
	FirstName varchar (50) not null constraint ck_Medalist_first_name_cannot_be_blank check(FirstName <> ''),
	LastName varchar (50) not null constraint ck_Medalist_last_name_cannot_be_blank check(LastName <> ''),
	Country varchar (50) not null constraint ck_Medalist_country_cannot_be_blank check(Country <> ''),
	YearBorn int not null constraint ck_Medalist_year_born_must_be_greater_than_zero check (YearBorn > 0),
    constraint ck_Medalist_year_born_must_be_before_olympic_year check(Yearborn < OlympicYear),
    constraint ck_Medalist_competitor_must_be_14_or_above check(OlympicYear - YearBorn >= 14),
    constraint u_Medalist_each_olympic_year_and_season_can_only_have_one_medal_per_sport_and_sport_subcategory unique(OlympicYear, season, medal, sport, SportSubcategory),
    
)
go

--Test Script

--year born before olympic year
insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2002, 'Summer', 'Monsey, New York', 'Tennis', 'Womens League' , 'gold', 'Rochel', 'Susholz', 'United States', 2003

--Olympic game must be post 1895
insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 1895, 'Summer', 'Monsey, New York', 'Tennis', 'Womens League' , 'gold', 'Rochel', 'Susholz', 'United States', 1850

insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 1896, 'Summer', 'Monsey, New York', 'Tennis', 'Womens League' , 'gold', 'Rochel', 'Susholz', 'United States', 1850

insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 1897, 'Summer', 'Monsey, New York', 'Tennis', 'Womens League' , 'gold', 'Rochel', 'Susholz', 'United States', 1850

--No null data
insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select null, 'Summer', 'Monsey, New York', 'Tennis', 'Womens League' , 'gold', 'Rochel', 'Susholz', 'United States', 2003

insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, null, 'Monsey, New York', 'Tennis', 'Womens League' , 'gold', 'Rochel', 'Susholz', 'United States', 2003

insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, 'Summer', null, 'Tennis', 'Womens League' , 'gold', 'Rochel', 'Susholz', 'United States', 2003

insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, 'Summer', 'Monsey, New York', null, 'Womens League' , 'gold', 'Rochel', 'Susholz', 'United States', 2003

insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, 'Summer', 'Monsey, New York', 'Tennis', null , 'gold', 'Rochel', 'Susholz', 'United States', 2003

insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, 'Summer', 'Monsey, New York', 'Tennis', 'Womens League' , null, 'Rochel', 'Susholz', 'United States', 2003

insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, 'Summer', 'Monsey, New York', 'Tennis', 'Womens League' , 'gold', null, 'Susholz', 'United States', 2003

insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, 'Summer', 'Monsey, New York', 'Tennis', 'Womens League' , 'gold', 'Rochel', null, 'United States', 2003

insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, 'Summer', 'Monsey, New York', 'Tennis', 'Womens League' , 'gold', 'Rochel', 'Susholz', null, 2003

insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, 'Summer', 'Monsey, New York', 'Tennis', 'Womens League' , 'gold', 'Rochel', 'Susholz', 'United States', null

-- no blank data or years under 1
insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 0, 'Summer', 'Monsey, New York', 'Tennis', 'Womens League' , 'gold', 'Rochel', 'Susholz', 'United States', 2003

insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, '', 'Monsey, New York', 'Tennis', 'Womens League' , 'gold', 'Rochel', 'Susholz', 'United States', 2003

insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, 'Summer', '', 'Tennis', 'Womens League' , 'gold', 'Rochel', 'Susholz', 'United States', 2003

insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, 'Summer', 'Monsey, New York', '', 'Womens League' , 'gold', 'Rochel', 'Susholz', 'United States', 2003

insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, 'Summer', 'Monsey, New York', 'Tennis', '' , 'gold', 'Rochel', 'Susholz', 'United States', 2003

insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, 'Summer', 'Monsey, New York', 'Tennis', 'Womens League' , '', 'Rochel', 'Susholz', 'United States', 2003

insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, 'Summer', 'Monsey, New York', 'Tennis', 'Womens League' , 'gold', '', 'Susholz', 'United States', 2003

insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, 'Summer', 'Monsey, New York', 'Tennis', 'Womens League' , 'gold', 'Rochel', '', 'United States', 2003

insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, 'Summer', 'Monsey, New York', 'Tennis', 'Womens League' , 'gold', 'Rochel', 'Susholz', '', 2003
insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, 'Summer', 'Monsey, New York', 'Tennis', 'Womens League' , 'gold', 'Rochel', 'Susholz', 'United States', 0

-- competitor must be 14 or above to compete
insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, 'Summer', 'Monsey, New York', 'Tennis', 'Womens League' , 'gold', 'Rochel', 'Susholz', 'United States', 2010

insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, 'Summer', 'Monsey, New York', 'Tennis', 'Womens League' , 'gold', 'Rochel', 'Susholz', 'United States', 2009

--each olympic year and season can only have one medal per sport and sport subcategory
insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, 'Summer', 'Monsey, New York', 'Tennis', 'Womens League' , 'gold', 'Rochel', 'Susholz', 'United States', 2009

insert Medalist (OlympicYear, Season, OlympicLocation, Sport, SportSubcategory, Medal, FirstName, LastName, Country, YearBorn)
select 2023, 'Summer', 'Toronto, Ontario', 'Tennis', 'Womens League' , 'gold', 'Sara', 'Gottlieb', 'Canada', 2010













/* 2
President
    The U.S Government used the data in the presidents table to provide the captions for new monuments engraved into the side of a mountain in NY.
    There was bad data in the table, some term ends and term starts were reversed. 
    So the caption engraved in the mountain says something like Served: 1900 to 1886. This was discovered on opening day by some of the audience.
    It is going to cost 1.4 million dollars to correct that error engraved into the mountain.
    Ensure all bad data possibilities are prevented.
    They have specified a few rules:
        No president's term can begin before 1776 when America became a country
        Term end cannot be before term start.
        A president must be at least 35 years old.
*/

--    Include test scripts that demonstrate the strength of your reinforced table.
--    Good Luck!

use RecordKeeperDB
drop table if exists president
go
		create table dbo.president(
		PresidentId int not null identity (1000,1) primary key,
		Num int not null constraint u_President_num_must_be_unique unique
            constraint ck_President_num_must_be_greater_than_zero check(Num > 0), 
		FirstName varchar(100) not null constraint ck_President_first_name_cannot_be_blank check(FirstName <> ''), 
        LastName varchar(100) not null constraint ck_President_last_name_cannot_be_blank check(LastName <> ''), 
        Party varchar(50) not null constraint ck_President_party_cannot_be_blank check(Party <> ''),
        DateBorn date not null constraint ck_President_date_born_cannot_be_blank check(DateBorn <> '' ),  
		DateDied datetime2,
		TermStart int not null constraint ck_President_term_must_begin_after_1775 check(TermStart >= 1776),
		TermEnd int,
        constraint ck_President_term_end_cannot_be_before_term_start check(TermEnd > TermStart),
        constraint ck_President_president_must_be_at_least_35_years_old_to_serve check(TermStart - year(DateBorn)>= 35)
	)
go

--Test Script
--No president's term can begin before 1776
insert president(Num, FirstName, LastName, Party, DateBorn, DateDied, TermStart, TermEnd)
select 50, 'Rochel', 'Susholz', 'Republican', '2003-09-03', null, 1775, 1883 

insert president(Num, FirstName, LastName, Party, DateBorn, DateDied, TermStart, TermEnd)
select 50, 'Rochel', 'Susholz', 'Republican', '2003-09-03', null, 1776, 1884 

insert president(Num, FirstName, LastName, Party, DateBorn, DateDied, TermStart, TermEnd)
select 50, 'Rochel', 'Susholz', 'Republican', '2003-09-03', null, 1777, 1885 

--Term end cannot be before term start
insert president(Num, FirstName, LastName, Party, DateBorn, DateDied, TermStart, TermEnd)
select 50, 'Rochel', 'Susholz', 'Republican', '2003-09-03', null, 1776, 1775

insert president(Num, FirstName, LastName, Party, DateBorn, DateDied, TermStart, TermEnd)
select 50, 'Rochel', 'Susholz', 'Republican', '2003-09-03', null, 1776, 1777

--A president must be at least 35 years old
insert president(Num, FirstName, LastName, Party, DateBorn, DateDied, TermStart, TermEnd)
select 51, 'Rochel', 'Susholz', 'Republican', '1990-09-03', null, 2024, 2028 

insert president(Num, FirstName, LastName, Party, DateBorn, DateDied, TermStart, TermEnd)
select 50, 'Rochel', 'Susholz', 'Republican', '1989-09-03', null, 2024, 2028














