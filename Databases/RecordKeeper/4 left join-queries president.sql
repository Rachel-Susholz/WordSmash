--Reports: For all reports never show null, rather show blank or 0 depending on data type
--1) Show all parties sorted in the descending order of amount of members elected to President. Include those with no presidents. Show party name, color and president count. 
select r.PartyName, isnull (c.Color, ''), PresCount = count(p.PresidentId)
from party r
left join color c
on c.ColorId = r.ColorId
left join President p 
on r.PartyId = p.PartyId
group by r.PartyName, c.Color
order by PresCount desc 
--2) Show all Presidents (Number, First name, Last name) and their party's color, sort by number
select President = concat (p.Num, ', ', p.FirstName, ', ', p.LastName), c.Color
from party r
join color c
on c.ColorId = r.ColorId
join President p 
on r.PartyId = p.PartyId 
order by p.Num
--3) Show the parties that have not had any members elected as President
select *
from party r
left join president p 
on r.PartyId = p.PartyId
where p.PresidentId is null
--4) Breaking News!! Someone from the Prohibition Party was just elected president! Insert the new president (you make up the info, do not include in  "data president" file)
insert president(PartyId, Num, FirstName, LastName, DateBorn, DateDied, TermStart, TermEnd)
select (select r.PartyId from party r where r.PartyName = 'Prohibition'), 45, 'Joel', 'McKensie', 1970, null, 2024, null
/*
5) The Times of CPU hired an investigative journalist to research any correlation between a Party's color and the amount of Executive Orders issued. 
    The investigator needs the following information: Show a list of colors and number of executive orders for each color, sort by highest number of executive orders to the lowest */
select c.Color, ExecutiveOrdersAmount = count(ExecutiveOrderId)
from color c
join party r
on c.ColorId = r.ColorId
left join President p 
on r.PartyId = p.PartyId 
left join ExecutiveOrders e
on p.PresidentId = e.PresidentId
group by c.Color
order by ExecutiveOrdersAmount desc

-- it wasn't clear from the question if parties with no color should be included
-- if you want to include executive orders made  by presidents belonging to parties with no color then:

select c.Color, ExecutiveOrdersAmount = count(ExecutiveOrderId)
from party r
left join color c
on c.ColorId = r.ColorId
left join President p 
on r.PartyId = p.PartyId 
left join ExecutiveOrders e
on p.PresidentId = e.PresidentId
group by c.Color
order by ExecutiveOrdersAmount desc

