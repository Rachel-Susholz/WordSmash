use RecordKeeperDB
go
drop table if exists Invention
go
create table dbo.Invention(
	InventionId int not null identity primary key,
	InventionName varchar (200) not null 
		constraint ck_Invention_InventionName_cannot_be_blank check(InventionName<> '') unique,
	InventionDesc varchar (max) not null 
		constraint ck_Invention_InventionDesc_cannot_be_blank check(InventionDesc<> ''),
	YearInvented int not null,
	InventorFirstName varchar (100) not null 
		constraint ck_Invention_InventorFirstName_cannot_be_blank check(InventorFirstName<> ''),
	InventorLastName varchar (100) not null 
		constraint ck_Invention_InventorLastName_cannot_be_blank check(InventorLastName<> ''),
	Country varchar (50) not null 
		constraint ck_Invention_Country_cannot_be_blank check(Country<> ''),
	YearBorn int not null,
	YearDied int,	
	Code as upper(concat(YearInvented,substring(InventorFirstName,1,1),substring(InventorLastName,1,1), substring((InventionName),1,2))) persisted
		constraint u_invention_code_must_be_unique unique,
		constraint c_invention_code_cannot_be_blank check (Code > '')
	)
go