/*
1.
The US Gov has prohibited certain words (listed below) from being used in political party names. 
Those may not even be camouflaged as part of another word.
Using a CTE insert the literal values below as new parties but omit the 'records' that contain prohibited words.

Prohibited words:
Hate
War
Kill

Parties
Flower Power, 1970, Violet
Love Powar, 1971, Green
Disco, 1980, White
Talent and Skill, 1990, Red
Rock and Roll, 1980, Pink
Phosphate Pros, 2022, no color 

*/
;
with x as 
    (select PartyName = 'Flower Power', YearFormed = 1970, Color = 'violet'
     union select PartyName = 'Love Powar', YearFormed = 1971, Color = 'Green'
     union select PartyName = 'Disco', YearFormed = 1980, Color = 'White'
     union select PartyName = 'Talent and Skill', YearFormed = 1990, Color = 'Red'
     union select PartyName = 'Rock and Roll', YearFormed = 1980, Color = 'Pink'
     union select PartyName = 'Phosphate Pros', YearFormed = 2022, Color = 'null'
     )
insert party(PartyName, YearFormed, ColorId)
select x.PartyName, x.YearFormed, c.ColorId
from x 
left join party p 
on p.PartyName = x.PartyName
left join color c 
on c.Color = x.Color
where x.PartyName not like '%hate%' 
and x.PartyName not like '%war%' 
and x.PartyName not like '%kill%'


/*
--2 Show all presidents where their age at term start is lower than the average age term start for their party. 
    Show the party name, average age at term start for the party, president number, last name, and age at term start.
*/
;
with x as 
    (
    select p.PartyId, r.PartyName, AverageAgeAtTermStart = avg(p.TermStart - year(p.DateBorn))
    from president p
    join party r
    on p.PartyId = r.PartyId
    group by PartyName, p.PartyId
    )
select x.PartyName, x.AverageAgeAtTermStart, p.Num, p.LastName, AgeAtTermStart = p.TermStart - year(p.DateBorn)
from x 
join president p 
on x.PartyId = p.PartyId
join party r on x.PartyName = r.PartyName
where x.AverageAgeAtTermStart > (p.TermStart - year(p.DateBorn))
 
--3. Set the color of the party with the most presidents to Gold
;
with x as 
    (
    select r.PartyName, p.PartyId, c.color, AmountOfPres = count(p.LastName)
    from president p
    join party r
    on p.PartyId = r.PartyId
    join color c 
    on r.ColorId = c.ColorId
    group by r.PartyName, p.PartyId, c.Color
    )
update c
set c.Color = 'gold'
--select PartyWithMostPres = max(AmountOfPres)
from x 
join color c
on x.color = c.Color
where AmountOfPres = 18
--How would I do this if I did not know that the max amount of presidents per party was 18? I cant do an update with an aggregate and I cant do a 
--aggregate on an aggregate, so how do I do a max count? I have the same question for number 4.

 

--4 Delete the executive orders of the party with the least presidential executive orders
;
with x as 
    (
    select r.PartyName, p.PartyId, e.PresidentId, AmountOfExecutiveOrders = count(e.ExecutiveOrderId)
    from party r
    join president p
    on p.PartyId = r.PartyId
    join ExecutiveOrders e
    on p.PresidentId = e.PresidentId
    group by r.PartyName, p.PartyId, e.PresidentId
    )
delete e 
-- select min(AmountOfExecutiveOrders)
from x 
join ExecutiveOrders e 
on x.PresidentId = e.PresidentId
where AmountOfExecutiveOrders = 1
