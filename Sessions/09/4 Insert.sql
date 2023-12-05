-- SM Excellent! 75% See comment, fix and resubmit.
/*
    1. The current presidential term is undergoing serious political challenges. 
       Two presidents were already impeached and the third is now beginning his term. 
       insert these three new presidents, the first two have already ended their term.
	    1) Jack Valento - Republican (Born 1980)
        2) Sam Smith - Democrat (Born 1964)
        3) Nick Wonder - Republican (Born 1995)
 */
insert president (Num, FirstName, LastName, Party, YearBorn, YearDied, TermStart, TermEnd)
select 47, 'Jack', 'Valento', 'Republican', 1980, null, 2021, 2022
union select 48, 'Sam', 'Smith', 'Democrat', 1964, null, 2022, 2023
union select 49, 'Nick', 'Wonder', 'Republican', 1995, null, 2023, null
/*
    2. After the recent unrest, a new law was made that multiple presidents can serve a term together. 
       Elections were held and all United States Olympic medalists from any 21st century Olympics were elected for the current term. 
       They are all Republicans. Please add them to the table.
*/
-- SM -50% Only US medalists.
insert president (Num, FirstName, LastName, Party, YearBorn, YearDied, TermStart, TermEnd)
select 50, m.FirstName, m.LastName, 'Republican', m.YearBorn, null, 2023, null 
from Medalist m 
where m.OlympicYear between 2001 and 2023
