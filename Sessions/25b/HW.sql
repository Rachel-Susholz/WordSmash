--AS Great job! 98% See comment and resubmit.
--1 All presidents are participating in the Olympics! In all sports! Show me a list of presidents (Number, Last Name), and each sport in the medalist table. Sort by president number.
--AS -2 No need for a CTE here. You can do the same thing with a basic cross join

select distinct m.sport, President = concat (p.Num,  ', ', p.LastName) 
from president p 
cross join medalist m 
order by p.Num
/*
--2 None of the presidents won any olympic medals. 
The Democrats want to try their hands at world records. They were advised to take it slow and try one category of world records first. 
You pick the category and show me a list of Democratic presidents (Num, Last Name) with a list of world records (just the record name) from your chosen category. 
Sort by record name, and then by president number
*/

select President = concat (p.Num,  ', ', p.LastName), w.RecordName 
from president p 
join party r
on p.PartyId = r.PartyId
cross join WorldRecord w
where r.PartyName = 'Democrat'
and w.Category = 'Dedication and Collections'
order by w.RecordName, p.Num

