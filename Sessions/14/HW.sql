-- medalist 

-- 1. Show a new column called Stars. For gold medalists show five stars, for silver show four stars and for bronze show three stars.
select *, Stars =
    case m.Medal 
    when 'gold' then '*****'
    when 'silver' then '****'
    when 'bronze' then '***'
    end
from medalist m
/* 2. The Olympic Committee has decided to assign certain medalists a color, which is decided based on a few specifications:
    If the Olympic location was France and the sport was Athletics or Figure Skating the color is red.
    If the location was Italy and the sport was Athletics or Canoeing then the color is orange. 
    If the location was Japan and was during the Winter and the sport was Cross-Country Skiing then the color is yellow.
    If the location was Greece and was during the summer and the sport was cycling then the color is Blue. 
    All other medalists will be green.
*/
select Color = 
    case
    when m.OlympicLocation like '%France' and m.sport in ('Athletics', 'Figure Skating') then 'red'
    when m.OlympicLocation like '%Italy' and m.sport in ('Athletics', 'Canoeing') then 'orange'
    when m.OlympicLocation like '%Japan' and m.sport = 'Cross-Country Skiing' and m.Season = 'Winter' then 'yellow'
    when m.OlympicLocation like '%Greece' and m.sport = 'cycling' and m.Season = 'Summer' then 'blue'
    else 'green'
    end
,*
from medalist m
--order by Color
/* 3. The Olympic Committee wants a list of all medalists.
      The gold and silver medalists should be sorted by last name (the type of medal does not affect the sort), 
      and all bronze should show below them sorted by last name.
*/

select  MedalRef = 
    case 
    when m.Medal in ('Gold', 'Silver') then 0
    when m.Medal = 'Bronze' then 1
    end
, m.Medal, m.LastName 
from Medalist m
order by MedalRef, m.LastName
--RS In a case like this, where I'm only working on one column in the case, how do I i use 'case medal when...' if I have 2 conditions in one column for one branch?

/* 4. Someone mistakenly put bad data into the Medalist table, which we must fix now.
      All American medalists under the age of 25 - their medals must be changed to Gold.
      Italian medalists over the age of 30 should be awarded Silver medals.
      French medalists over the age of 35 that performed in Summer games should have their medals changed to bronze.
      Any medalist from Denmark whose last name contains an S should be changed to gold. All other medalists should remain the same.
*/
update m
set m.Medal =
--select RevisedMedals = 
    case 
    when m.country = 'United States' and m.OlympicYear - m.YearBorn < 25 then 'Gold'
    when m.country = 'Italy' and m.OlympicYear - m.YearBorn > 30 then 'silver'
    when m.country = 'Frsance' and m.OlympicYear - m.YearBorn > 35 and m.Season = 'Summer' then 'bronze'
    when m.country = 'Denmark' and m.LastName like '%s%' then 'gold'
    else m.Medal
    end
from medalist m
/* 5. 
    Create a new budget for next year, base it on the latest year in the budget table. Adjust the new budget as follows:
    Department of Education - increase by 90%
    Department of Health and Human Services - triple the budget
    Environmental Protection Agency - cut it in half
    Department of the Treasury = 10 million
    All else increase by 20%
*/
insert budget(Department, BudgetYear, Millions)
select 
    b.department,
    max(b.BudgetYear) + 1, 
    case
    when b.department = 'Department of Education'  then b.Millions * 1.9 
    when b.department = 'Department of Health and Human services'  then b.Millions * 3
    when b.department = 'Environmental Protection Agency' then b.Millions / 2
    when b.department = 'Department of the Teasury' then 10000000
    else b.Millions * 1.2 
    end
from budget b
where b.BudgetYear = 2021
group by b.Department, b.Millions 
--RS I worked on this question for a long time. I knew I wanted to use a max for the year column and therefore needed a group by clause.
--However, I dont really understand the logic of what I was doing with the group by, like I dont get why when I tried just grouping it according 
--to just department it wasnt enough. Can you explain it to me?



