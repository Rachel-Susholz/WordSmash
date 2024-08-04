use RocketDb 
go 
delete journey
go 
delete rocket 
go 


insert Rocket (RocketName, YearBuilt)
select 'Falcon 9', 2010
union select 'Atlas V', 2002
union select 'Terran 1', 2023
union select 'Delta IV Heavy', 2004
union select 'Long March 5B', 2016

insert Journey (RocketId, PlanetName, DistanceTraveled, LaunchDate, ArrivalDate, ReturnDate)
select r.RocketId,'Mars', 2250000.00, '2023-05-15', '2023-11-02', '2024-01-15' from Rocket r where r.YearBuilt = 2016
union select r.RocketId,'Jupiter', 7000000.00, '2022-08-10', '2023-03-25', '2023-07-08' from Rocket r where r.YearBuilt = 2004
union select r.RocketId,'Venus', 420000.00, '2024-01-20', '2024-04-05', '2024-07-22' from Rocket r where r.YearBuilt = 2023
union select r.RocketId,'Mercury', 770000.00, '2023-11-30', '2024-02-15', '2024-05-01' from Rocket r where r.YearBuilt = 2004
union select r.RocketId,'Moon', 3844.50, '2022-10-05', '2022-10-11', '2022-10-20' from Rocket r where r.YearBuilt = 2004
union select r.RocketId,'Saturn', 12000000.00, '2022-12-01', null, null from Rocket r where r.YearBuilt = 2010
union select r.RocketId,'Mars', 2250000.70, '2023-09-20', null, null from Rocket r where r.YearBuilt = 2016
union select r.RocketId,'Jupiter', 7000000.00, '2024-03-10', null, null from Rocket r where r.YearBuilt = 2023
union select r.RocketId,'Venus', 420000.00, '2023-06-15', null, null from Rocket r where r.YearBuilt = 2002