--1 show a list of rockets
select * from rocket r
--2 show a list of journeys, do not show foreign key
select j.JourneyId, j.PlanetName, j.DistanceTraveled, j.LaunchDate, j.ArrivalDate, J.ReturnDate from journey j
--3 list each rocket, planet and distance traveled. sort by rocket and then by planet
select RocketName, PlanetName, DistanceTraveled
from Rocket r
join Journey j
on r.RocketId = j.RocketId
order by RocketName, PlanetName
--4 same as 3 but only for 2 rockets
select RocketName, PlanetName, DistanceTraveled
from Rocket r
join Journey j
on r.RocketId = j.RocketId
where RocketName in ('Atlas V', 'Delta IV Heavy')
order by RocketName, PlanetName
--5 same as 3 but only for 2 planets
select RocketName, PlanetName, DistanceTraveled
from Rocket r
join Journey j
on r.RocketId = j.RocketId
where PlanetName in ('Venus', 'Jupiter')
order by RocketName, PlanetName
--6 show the number of trips per rocket, total distance traveled, date of first trip, date of last trip
select RocketName, TripsPerRocket = count (*), TotalDistance = sum (DistanceTraveled), FirstTrip = min(LaunchDate), LastTrip = max(LaunchDate)
from Rocket r 
join Journey j 
on r.RocketId = j.RocketId
group by RocketName
--7 show the number of rockets and the average year built per planet
 select NumOfRockets = count (RocketName), AvgYearBuilt = avg (YearBuilt), PlanetName
 from rocket r 
 join journey j 
 on r.RocketId = j.RocketId
 group by PlanetName