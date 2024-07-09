use RecordKeeperDB
go 
drop table if exists Medalist
go
create table dbo.Medalist(
	MedalistId int not null identity primary key,
	OlympicYear int not null constraint ck_Medalist_olympic_year_must_be_greater_than_1895 check(OlympicYear >= 1896),
	Season varchar (50) not null
		constraint c_medalist_season_cannot_be_blank check(Season > ''),
	OlympicLocation varchar (100) not null
		constraint c_medalist_location_cannot_be_blank check (OlympicLocation > ''),
	Sport varchar (100) not null
		constraint c_medalist_sport_cannot_be_blank check(Sport > ''),
	SportSubcategory varchar (100) not null
		constraint c_medalist_sport_subcategory_name_cannot_be_blank check(SportSubcategory > ''),
	Medal varchar (6) not null 
		constraint c_medalist_medal_cannot_be_blank check (Medal > ''),
	FirstName varchar (50) not null
		constraint c_medalist_first_name_cannot_be_blank check (FirstName > ''),
	LastName varchar (50) not null
		constraint c_medalist_last_name_cannot_be_blank check (LastName > ''),
	Country varchar (50) not null
		constraint c_medalist_country_cannot_be_blank check (Country > ''),
	YearBorn int not null,
		constraint ck_Medalist_year_born_must_be_before_olympic_year check(Yearborn < OlympicYear),
    	constraint u_Medalist_each_olympic_year_and_season_can_only_have_one_medal_per_sport_and_sport_subcategory unique(OlympicYear, season, medal, sport, SportSubcategory),
    	constraint ck_Medalist_Competitor_must_be_14_or_above check(OlympicYear - YearBorn >= 14),
	Code as concat(substring(upper(FirstName),1,3),substring(upper(LastName),1,2), substring(Medal,1,1), substring(Sport,1,1),OlympicYear) persisted
		constraint c_medalist_code_cannot_be_blank check (Code > '')
		constraint u_medalist_code_must_be_unique unique	
)
go