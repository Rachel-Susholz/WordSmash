delete Patient
go

insert Patient (PatientFirstName, PatientMiddleName, PatientLastName, DateOfBirth, Gender, SSN, FloorNumber, RoomNumber, AdmitDate, DischargeDate, AdmitConditionNum, DischargeConditionNum)
select

--PatientFirstName
    case 
        when charindex(' ', p.FirstName) > 0 then substring(p.FirstName, 1, charindex(' ', p.FirstName) - 1) 
        else p.FirstName 
        end,

-- PatientMiddleName 
    case
        when charindex(' ', p.FirstName) > 0 then substring(p.FirstName, charindex(' ', p.FirstName) + 1, 20)
        else ''
        end,
    p.LastName, 
    p.DateBorn,

-- Gender 
    'm',

-- SSN
   concat(p.TermStart, p.TermsServed, year(p.DateBorn)),
    
-- FloorNumber
    case 
        when p.TermStart - year(DateBorn) < 50 then 2
        when p.TermStart - year(DateBorn) between 50 and 65 then 3
        else 4
        end,

-- RoomNumber
    p.TermStart - year(p.DateBorn),

-- AdmitDate
   dateadd(year, p.num, p.dateborn),
  

-- DischargeDate   
    case 
        when p.Party not in ('Democrat', 'Republican') then datefromparts(p.TermStart + 10, 01, 07)
        when p.AgeAtDeath between 50 and 58 then datefromparts(p.TermStart + 10, 01, 07)
        when p.AgeAtDeath between 70 and 73 then datefromparts(p.TermStart + 10, 01, 07)
        when p.AgeAtDeath between 75 and 77 then datefromparts(p.TermStart + 10, 01, 07)
        else null       
        end,

-- AdmitConditionNum
    case 
        when p.FirstName like '% %' then 2
        else 3
        end,

-- DischargeConditionNum
    case 
        when p.Party not in ('Democrat', 'Republican') then 1
        when p.AgeAtDeath between 50 and 58 then 2
        when p.AgeAtDeath between 70 and 73 then 3
        when p.AgeAtDeath between 75 and 77 then 4
        else null
        end
        
from RecordKeeperDB.dbo.president p
go

