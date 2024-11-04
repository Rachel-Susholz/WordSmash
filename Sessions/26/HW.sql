--AS Excellent! 100%

/*
The government is starting a new program to award medals to presidents for outstanding service. 
Add tables to store medals and award them to presidents. A medal can be assigned to more than one president. 
When awarding a medal to a president record the date and time of the award.
A president cannot receive the same award more than once.

Medals:
	Made America Great
	(make up several more)

Ensure that sample data provides A) president with no medals
                                 B) president with only one medal
                                 C) president with multiple medals
                                 D) a medal shared by multiple presidents
                                 E) a medal that has never been awarded to a president
                                 
*/


drop table if exists PresidentMedal 
drop table if exists Medal
go 
create table dbo.Medal(
    MedalId int not null identity primary key,
    MedalName varchar (100) not null 
        constraint u_Medal_Name unique
        constraint c_Medal_Name_cannot_be_blank check (MedalName <> '')
)
go 
insert Medal(MedalName)
select 'Made America Great'
union select 'Preserved the Union'
union select'Defender of Liberty'
union select'Pioneer of Progress'
union select'Champion of Democracy'

create table dbo.PresidentMedal(
    PresidentMedalId int not null identity primary key,
    PresidentId int not null constraint f_President_PresidentMedal foreign key references President(PresidentId), 
    MedalId int not null constraint f_Medal_PresidentMedal foreign key references Medal(MedalId),
    AwardTime datetime default current_timestamp 
    constraint u_PresidentMedal_President_Medal unique (PresidentId, MedalId)
)
go 
; 
with x as (
    select MedalName = 'Made America Great', FirstName = 'George', LastName = 'Washington'
    union select 'Made America Great', 'Abraham', 'Lincoln'
    union select'Defender of Liberty', 'Barack', 'Obama'
    union select'Pioneer of Progress', 'John', 'Adams'
    union select'Champion of Democracy', 'Barack', 'Obama'
) 
insert PresidentMedal (MedalId, PresidentId) 
select m.MedalId, p.PresidentId
from x 
left join Medal m 
on m.MedalName = x.MedalName
left join president p
on p.FirstName = x.FirstName 
and p.LastName = x.LastName

--1) Select all presidents and any medals they may have, sorted by medal and president number. Show Name, Number, Medal, Party


select p.FirstName, p.LastName, p.Num, m.MedalName, r.PartyName 
from president p 
left join party r
on p.PartyId = r.PartyId
left join PresidentMedal pm 
on p.PresidentId = pm.PresidentId
left join Medal m 
on m.MedalId = pm.MedalId
order by m.MedalName, p.Num
--RS It runs for me

--Obviously, if this is just asking to sort by medal id and only show the medal id, I would not join the medal table.
--2) Show the Medal that was awarded the most times.
select top 1 m.MedalName, AmountOfTimesAwarded = count(pm.MedalId) 
from medal m 
left join PresidentMedal pm 
on m.MedalId = pm.MedalId
group by m.MedalName
order by AmountOfTimesAwarded desc
--3) Show all medals and the amount of times it has been awarded. Zero if never awarded.
select m.MedalName, AmountOfTimesAwarded = count(pm.MedalId) 
from medal m 
left join PresidentMedal pm 
on m.MedalId = pm.MedalId
group by m.MedalName
--4a) Show all parties and the number of medals awarded to it's presidents. Omit party if no medals

select r.PartyName, NumOfMedalsAwarded = count(pm.MedalId)
from PresidentMedal pm
join president p
on p.PresidentId = pm.PresidentId 
join party r
on p.PartyId = r.PartyId
group by r.PartyName
--4b) Same as 4a, but show zero if no medals awarded to a party's presidents


select r.PartyName, NumOfMedalsAwarded = count(pm.MedalId)
from party r
join president p
on p.PartyId = r.PartyId 
left join PresidentMedal pm
on p.PresidentId = pm.PresidentId
group by r.PartyName
--5) Which medal(s) has never been awarded
select m.MedalName, AmountOfTimesAwarded = count(pm.MedalId) 
from medal m 
left join PresidentMedal pm 
on m.MedalId = pm.MedalId
group by m.MedalName
having count(pm.MedalId) = 0

--6) Pick a president that has been awarded at least one medal, and strip him of his awards. Do not delete the medal.
--select *
delete pm
from president p
join PresidentMedal pm 
on p.PresidentId = pm.PresidentId
where p.FirstName = 'Barack'
and p.LastName = 'Obama'
--7) We are awarding a medal to all presidents, the medal name is "Champion of Internet Safety". 
--a) Create the medal and award it to all presidents
insert Medal(MedalName)
select 'Champion of Internet Safety' 

insert PresidentMedal(presidentid, medalid)
select p.PresidentId, m.MedalId
from President p
cross join medal m 
where m.MedalName = 'Champion of Internet Safety'


--b) Uh. Somebody pointed out the presidents before 1993 could not have championed internet safety. Remove the award from all presidents that ended their terms prior to that year.
delete pm 
--select * 
from president p 
join PresidentMedal pm 
on p.PresidentId = pm.PresidentId
join medal m 
on m.MedalId = pm.MedalId
where p.TermEnd < 1993
and m.MedalName = 'Champion of Internet Safety'









