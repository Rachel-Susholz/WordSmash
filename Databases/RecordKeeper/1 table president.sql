-- AS  70%. Please fix and resubmit 
-- The president needs to refrence the partys, a few presidents can have to same party.
-- If you need help with the concepte please reach out to a mentor.
-- paste this on the bottom of the table file
use RecordKeeperDB
go
drop table if exists party
go
drop table if exists president
go
create table dbo.president
(
	PresidentId int not null identity primary key,
	Num int not null constraint u_President_num_must_be_unique unique
		constraint ck_President_num_must_be_greater_than_zero check(Num > 0),
	FirstName varchar(100) not null constraint ck_President_first_name_cannot_be_blank check(FirstName <> ''),
	LastName varchar(100) not null constraint ck_President_last_name_cannot_be_blank check(LastName <> ''),
	DateBorn date not null constraint ck_President_date_born_cannot_be_blank check(DateBorn <> '' ),
	DateDied datetime2,
	TermStart int not null constraint ck_President_term_must_begin_after_1775 check(TermStart >= 1776),
	TermEnd int,
	constraint ck_President_term_end_cannot_be_before_term_start check(TermEnd > = TermStart),
	constraint ck_President_president_must_be_at_least_35_years_old_to_serve check(TermStart - year(DateBorn)>= 35)
)
go
alter table President drop column if exists AgeAtDeath
go
alter table President add AgeAtDeath as datediff(year, DateBorn, DateDied) persisted 
go
alter table President drop column if exists YearsServed
go
alter table President add YearsServed as TermEnd - TermStart persisted 
go
alter table President drop column if exists TermsServed
go
alter table President add TermsServed as (TermEnd - Termstart) / 4  persisted
go

create table dbo.party
(
	PartyId int not null identity primary key,
	PresidentId int not null
		constraint f_president_party foreign key references President(PresidentId),
	PartyName varchar (25) not null
		constraint c_party_name_cannot_be_blank check (PartyName <> ''),
	YearFormed int not null,
	Color varchar (10) not null
		constraint c_party_color_cannot_be_blank check (Color <> '')
)

go
