--1)
--For government audit: list of all patients discharged, presented as: last name, first name, date of admit, date of discharge, condition upon admit and discharge. 
--We want to show our success stories on top, order by condition at discharge.
Select 
    p.patientLastName, 
    p.patientFirstName, 
    p.AdmitDate, 
    p.DischargeDate, 
    p.AdmitConditionDesc,
    p.DischargeConditionDesc
from patient p
where p.DischargeDate is not null
order by p.DischargeConditionNum
--2)
--For facility admin: show list of patients whose condition deteriorated under our care, include condition descriptions.
select p.patientFirstName, p.patientLastName, p.DateOfBirth, p.SSN, p.AdmitConditionNum, p.AdmitConditionDesc, p.DischargeConditionNum, p.DischargeConditionDesc, * 
from patient p
where p.AdmitConditionNum < p.DischargeConditionNum
and p.DischargeDate is not null
--3)
--Show me the average days patients stayed at our facility, per condition at admit. For patients that are not discharged yet calculate average days from the current date.
select AverageDaysAtFacility = avg(Datediff(year, p.AdmitDate, p.DischargeDate)), p.AdmitConditionNum
from patient p
where p.DischargeDate is not null
group by p.AdmitConditionNum

select AverageDaysAtFacility = avg(Datediff(year, p.AdmitDate, getdate())), p.AdmitConditionNum
from patient p
where p.DischargeDate is null 
group by p.AdmitConditionNum
--4)
--Show me the numeric change of condition from admit to discharge and the number of patients with that change.
select NumChangeInCondition = p.AdmitConditionNum - p.DischargeConditionNum, PatientCount = count(p.patientFirstName)
from patient p
where p.DischargeDate is not null
group by p.AdmitConditionNum - p.DischargeConditionNum 
order by NumChangeInCondition desc



