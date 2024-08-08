-- AS Great job 100%
-- Queries

--a) list all executive orders sorted by page number, display the official executive order format
select ExecutiveOrders = concat('Order No. ', e.OrderNumber, ', ', e.VolumeNumber, ' ', e.OrderCode, ' ', e.PageNumber, ' ', e.IssueYear, '. ', e.OrderName)
from ExecutiveOrders e 
order by e.PageNumber
--b) same as (a) but include the presidents name
select ExecutiveOrders = concat(p.FirstName, ', ', p.LastName, ': ', 'Order No. ', e.OrderNumber, ', ', e.VolumeNumber, ' ', e.OrderCode, ' ', e.PageNumber, ' ', e.IssueYear, '. ', e.OrderName)
from president p
join ExecutiveOrders e 
on p.PresidentId = e.PresidentId
order by e.PageNumber
--c) same as (b) but include the party name
select ExecutiveOrders = concat(p.FirstName, ', ', p.LastName, ' - ', r.PartyName, ': ', 'Order No. ', e.OrderNumber, ', ', e.VolumeNumber, ' ', e.OrderCode, ' ', e.PageNumber, ' ', e.IssueYear, '. ', e.OrderName)
from party r
join president p 
on r.PartyId = p.PartyId
join ExecutiveOrders e 
on p.PresidentId = e.PresidentId
order by e.PageNumber
--d) show number of executive orders per president for presidents that issued 3 or more orders. sort by highest number of orders
select NumOfOrders = count(*), p.LastName
from president p
join ExecutiveOrders e 
on p.PresidentId = e.PresidentId
group by  p.LastName
having count(*) > = 3 
order by NumOfOrders desc 
--e) show number of executive orders per party
select NumOfOrders = count(*), r.PartyName
from party r
join President p
on r.PartyId = p.PartyId
join ExecutiveOrders e 
on p.PresidentId = e.PresidentId
group by r.PartyName 
--f) pick a party that has one or more executive orders and delete the party
delete e
--select *
from party r
join president p 
on r.PartyId = p.PartyId
join ExecutiveOrders e 
on p.PresidentId = e.PresidentId
where r.PartyName = 'National Union'

delete p
--select *
from party r
join president p 
on r.PartyId = p.PartyId
where r.PartyName = 'National Union'

delete r 
from party r 
where r.PartyName = 'National Union'


--g) for a particular party with exec orders update all to not upheld
update e
set e.OrderStatus = 0
--select e.OrderStatus 
from party r
join president p 
on r.PartyId = p.PartyId
join ExecutiveOrders e 
on p.PresidentId = e.PresidentId
where r.PartyName = 'Federalist'
