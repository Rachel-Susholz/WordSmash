use RecordKeeperDB
go
drop table if exists WorldRecord
go
create table dbo.WorldRecord(
	WorldRecordId int not null identity primary key,
	Category varchar (100) not null
		 constraint ck_WorldRecord_Category_cannot_be_blank check(Category <> ''),
	RecordName varchar (200) not null  
		constraint ck_WorldRecord_RecordName_cannot_be_blank check(RecordName <> '')
		constraint u_WorldRecord_RecordName_must_be_unique unique,
	RecordDesc varchar (max) not null  
		constraint ck_WorldRecord_RecordDesc_cannot_be_blank check(RecordDesc<> ''),
	FullName varchar (100) not null
	    constraint ck_WorldRecord_FirstName_cannot_be_blank check(FullName <> ''),
	Amount decimal not null 
		constraint ck_WorldRecord_Amount_greater_than_0 check(Amount > 0), 
	UnitOfMeasure varchar (100) not null 
		constraint ck_WorldRecord_UnitofMeasure_cannot_be_blank check(UnitofMeasure<> ''),
	YearAchieved int not null,
	Country varchar (50) not null
		constraint ck_WorldRecord_Country_cannot_be_blank check(Country <> ''),
	Code as concat(substring(replace(RecordName,' ', ''),1,20),YearAchieved) persisted 
		constraint c_WorldRecord_code_cannot_be_blank check (Code > '')
		constraint u_WorldRecord_code_must_be_unique unique
	)
go