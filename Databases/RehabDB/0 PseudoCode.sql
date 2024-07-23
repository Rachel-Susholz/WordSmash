/*


RehabDB

Patient
    PatientID int not null 
        primary key
    PatientFirstName varchar (20) not null 
        not blank
    PatientMiddleName varchar (20) not null
        default to blank if no middle name
    PatientLastName varchar (30) not null
        not blank
    DOB date not null 
    Gender char (1) not null
        in m or f
    SSN char (9)
    FloorNumber tinyint not null 
        not blank
        must be in 2 3 4
    RoomNumber tinyint not null
        not blank
    AdmitDate date not null
        cannot be future date
    DischargeDate date null
    AdmitConditionNum int not null
        must be in 2 or 3
    DischargeConditionNum int null
        must be in 1, 2, 3, 4

    InsertDate datetime not null 
        default to current date
    AdmitConditionDesc varchar (30) not null
        not blank
        computed: when 2 then Minor Loss of Functionalityand when 3 then Major Loss of Functionality
    DischargeConditionDesc varchar (30) null
        computed: when 1 then Good Health and when 2 then Minor Loss of Functionality and when 3 then Major Loss of Functionality and when 4 then Deceased



    DOB must be less than admit date
    discharge date must be after admitdate
    DischargeCondition and DischargeDate either both null or both filled
    

*/