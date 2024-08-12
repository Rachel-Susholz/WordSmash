--1 All presidents are participating in the Olympics! In all sports! Show me a list of presidents (Number, Last Name), and each sport in the medalist table. Sort by president number.
;
with x as 
    (
    select distinct m.Sport
    from medalist m
    )
select President = concat (p.Num,  ', ', p.LastName), x.Sport
from x
cross join president p 
order by p.Num
/*
--2 None of the presidents won any olympic medals. 
The Democrats want to try their hands at world records. They were advised to take it slow and try one category of world records first. 
You pick the category and show me a list of Democratic presidents (Num, Last Name) with a list of world records (just the record name) from your chosen category. 
Sort by record name, and then by president number
*/

select President = concat (p.Num,  ', ', p.LastName), w.RecordName 
from
president p 
join party r
on p.PartyId = r.PartyId
cross join WorldRecord w
where r.PartyName = 'Democrat'
and w.Category = 'Dedication and Collections'
order by w.RecordName, p.Num