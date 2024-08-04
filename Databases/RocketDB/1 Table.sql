use RocketDB
go 
drop table if exists dbo.Journey
go 
drop table if exists dbo.Rocket 
go 
create table dbo.Rocket(
    RocketId int not null primary key identity, 
    RocketName varchar (50) 
        constraint u_rocket_name_must_be_unique unique,
    YearBuilt int not null
)

go 
 create table dbo.Journey(
    JourneyId int not null primary key identity, 
    RocketId int not null 
        constraint f_rocket_journey foreign key references Rocket(RocketId), 
    PlanetName varchar(50) not null 
        constraint c_journey_planet_name_cannot_be_blank check (PlanetName <> ''),
    DistanceTraveled decimal (15, 2) not null
        constraint c_distance_must_be_greater_than_zero check (DistanceTraveled > 0),
    LaunchDate date not null,
    ArrivalDate date null,
    ReturnDate date null
)
go