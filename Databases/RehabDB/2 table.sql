--AS Great job! 93% Please see comment and resubmit.
use RehabDB
go

drop table if exists Patient
go

create table dbo.Patient(
--AS All column names should be propercased ie: PatientId
    PatientID int not null identity primary key,
    PatientFirstName varchar (20) not null 
        constraint c_patient_first_name_cannot_be_blank check(PatientFirstName <> ''),
    PatientMiddleName varchar (20) not null
        default '',
    PatientLastName varchar (30) not null
        constraint c_patient_last_name_cannot_be_blank check(PatientLastName <> ''),
    DateOfBirth date not null,
    Gender Char (1) not null
        constraint c_patient_gender_must_be_either_male_or_female check(Gender in ('M', 'F')),
--AS Check that SSN is all numeric charachters ie: check(SSN like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
--AS -2 SSN must be unique
    SSN char (9) not null,
    FloorNumber tinyint not null 
        constraint c_patient_floor_number_must_either_be_two_three_or_four check(FloorNumber in (2, 3, 4)),
    RoomNumber tinyint not null
--AS -1 Constraint msg should say room number must be greater than zero.
        constraint c_patient_room_number_cannot_be_blank check(RoomNumber > 0),
    AdmitDate date not null
        constraint c_patient_admit_date_cannot_be_future_date check(AdmitDate <= getdate()),
--AS -2 Check that discharged date isn't future date.
    DischargeDate date null,
    AdmitConditionNum int not null
        constraint c_patient_admit_condition_must_be_either_two_or_three check(AdmitConditionNum in (2, 3)),
    DischargeConditionNum int null,
        constraint c_patient_discharge_condition_must_be_either_one_two_three_or_four check(DischargeConditionNum in (1, 2, 3, 4)),
    AdmitConditionDesc as case 
        when AdmitConditionNum = 2 then 'Minor Loss of Functionality'
        when AdmitConditionNum = 3 then 'Major Loss of Functionality'
        end
        persisted,
    DischargeConditionDesc as case
        when DischargeConditionNum = 1 then 'Good Health'
        when DischargeConditionNum = 2 then 'Minor Loss of Functionality'
        when DischargeConditionNum = 3 then 'Major Loss of Functionality'
        when DischargeConditionNum = 4 then 'Deceased'
        end
        persisted,
    InsertDate datetime not null 
        default getdate(),
--AS Tip: You can combine the following 2 constraints using a between.
    constraint c_patient_DOB_must_be_less_than_admit_date check(DateOfBirth < AdmitDate),
    constraint c_patient_discharge_date_must_be_after_admit_date check(DischargeDate > AdmitDate),
--AS -2 Leave the desc columns out of this constraint since they are computed columns so they can't be inserted wrong.
    constraint c_patient_discharge_conditon_num_and_desc_and_discharge_date_either_must_all_have_values_or_all_be_null
        check((DischargeConditionNum is null and DischargeConditionDesc is null and DischargeDate is null) 
        or (DischargeConditionNum is not null and DischargeConditionDesc is not null and DischargeDate is not null))
 )   
 
