-- SM Excellent! 97% See comments, fix and resubmit.
--re run the data before doing each question

--1 John F Kennedy was a hoax, delete him from the table and reduce the number for all subsequent presidents (requires two statements)
delete p
--select *
from president p 
where p.LastName = 'Kennedy'

update p
set p.Num = p.Num - 1
--select *
from president p 
where p.Num >35
--2 Add "Short Term" to all republican presidents' first names for those who served less than 1 term (less than 4 years) after 1900.
update p 
set p.FirstName = p.FirstName + ' "Short Term"'
--select TermsServed = (p.TermEnd - p.TermStart) / 4 , * 
from president p 
where p.TermEnd - p.TermStart < 4 
and p.TermStart > 1900
and p.Party = 'Republican'
--3 Breaking News: Robert Wilson really won the last election. End the term of the current president and enter Robert Wilson as the next president.
-- SM -20% How do you know the number of current president? Use value that will "always" return serving president.
update p 
set p.TermEnd = 2023
--select p.Num, *
from president p 
where p.TermEnd = null
-- RS -Can you tell me how to use value that will "always" return serving president? Thank you for all your tips!
-- SM What is the differents in the data between the serving president and the other presidents? There's only one column that has a different value.
-- Check on that value.
-- RS - Thank you so much!

insert president (Num, FirstName, LastName, Party, YearBorn, YearDied, TermStart, TermEnd)
select 47, 'Robert', 'Wilson', 'Republican', 1976, null, 2023, null
--4 Zoom to the future! Add grandchildren for each of the past presidents. They all have the same last name, and first name + Jr. Add to president number and all 'Years' and 'Terms' columns so that all data is (or at least could be) correct.
insert president (Num, FirstName, LastName, Party, YearBorn, YearDied, TermStart, TermEnd)
select p.Num + 46, p.FirstName + ' Jr.', p.LastName, p.Party, p.YearBorn + 250, p.YearDied + 250, p.TermStart + 250, p.TermEnd + 250 
from president p

--5 Congratulations! You were elected for the next term. Add this record to the president table. Choose your party name and set 5 existing presidents to your party. 
insert president (Num, FirstName, LastName, Party, YearBorn, YearDied, TermStart, TermEnd)
select 47, 'Rachel', 'Susholz', 'Right Wing', 2003, null, 2023, null

update p
set p.Party = 'Right Wing'
--select * 
from president p 
where p.Num > 42
