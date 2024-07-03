--AS Nice work! 100% See one tip, no need to resubmit.
select * from states s
/*
1. We need to analyze current US state population based on the century that each state was admitted to the union.
Show the number of states and the average, max, and min populations per century of admittance. Show in three reports, break it up by the century, 1700s, 1800s, 1900s. 
The columns should be the number of states, year range (1700s, 1800s,1900s) and then the average, min, max
*/
select StatesAdmitted = count(*), YearRange = '1700s', AveragePop = avg(s.PopValue), MinPop = min(s.PopValue), MaxPop = max(s.PopValue)   
from states s
where year(s.admitted) between 1700 and 1799

select StatesAdmitted = count(*), YearRange = '1800s', AveragePop = avg(s.PopValue), MinPop = min(s.PopValue), MaxPop = max(s.PopValue)   
from states s
where year(s.admitted) between 1800 and 1899

select StatesAdmitted = count(*), YearRange = '1900s', AveragePop = avg(s.PopValue), MinPop = min(s.PopValue), MaxPop = max(s.PopValue)   
from states s
where year(s.admitted) between 1900 and 1999
/*
2. We are studying the impact of the presidency and his political affiliation on the longevity of the president. 
a) Show the average life span of non-living presidents per party. Sort by average lifespan and then by party.
b) Same as (a) but also break it up per the number of years served
c) Same as (b) but only show those with an average life span of less than 70
*/
select * from president p
--a)
--AS Improvement: Use the datediff function which is specifically for finding the difference in 2 dates ie: datediff(year, dateborn, datedied)
select AvgLifeSpan = avg(year(p.DateDied)- year(p.DateBorn)), p.Party 
from president p
where p.DateDied is not null
group by p.Party 
order by AvgLifeSpan, p.Party

--b)
select AvgLifeSpan = avg(year(p.DateDied)- year(p.DateBorn)), p.Party, YearsServed = p.TermEnd - p.TermStart
from president p
where p.DateDied is not null
group by p.Party, p.TermEnd - p.TermStart
order by AvgLifeSpan, p.Party

--c)
select AvgLifeSpan = avg(year(p.DateDied)- year(p.DateBorn)), p.Party, YearsServed = p.TermEnd - p.TermStart
from president p
where p.DateDied is not null
group by p.Party, p.TermEnd - p.TermStart
having avg(year(p.DateDied)- year(p.DateBorn)) < 70
order by AvgLifeSpan, p.Party
/*
3. US Gov is trying to cut costs. The economy changed after the stock market crash of 1987.
We need to produce list of departments with their max, average, and minimum budgets after 1987.
We only need to look at those with max or average above 10000 (million). 
Do not include Department of Homeland Security and Department of Veterans Affairs, as they are not subject to budget cuts.
Sort by the biggest spenders on top.
*/
select * from budget b

select b.Department, MaxBudget = max(b.Millions), AvgBudget = avg(b.Millions), MinBudget = min(b.Millions)
from budget b
where b.BudgetYear > 1987 and b.Department not in ('Department of Homeland Security', 'Department of Veterans Affairs')
group by b.Department
having max(b.Millions) > 10000 or avg(b.Millions) > 10000
order by MaxBudget desc

/*
4. The International Monetary Fund wants to stimulate the economy with an advertising campaign highlighting countries with young innovators.
Show the number of inventors as stars (*) per country that were under 35 at the time of their invention, exclude countries that have only one inventor. 
Sort by number of inventors from high to low, and then by country
*/
Select * from invention i

Select NumOfInventors = replicate('*',count(*)), i.Country
from invention i
where i.YearInvented - i.YearBorn < 35
group by i.Country
having count(*) > 1
order by NumOfInventors desc, i.Country
