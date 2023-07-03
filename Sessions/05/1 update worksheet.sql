--WorldRecord, use long hand unless otherwise specified, do as select showing before and after, and then convert to update, after each question reinsert the original data

--1 using shorthand syntax update the 'Country' for all records to USA
update WorldRecord set Country = 'USA'
--2 using longhand syntax update the 'Country' for all records to Japan
update w 
set w.Country = 'Japan'
--select 'Japan', w.Country, w.*
from WorldRecord w
--3 using shorthand update all records so their category is "misc" and country = "Russia"
update WorldRecord set Category = 'misc', Country = 'Russia'
--4 The speed records were entered incorrectly, they were actually 10 times as fast. Multiply the data in the amount column, don't worry about the other columns.
update w
set w.Amount = w.Amount * 10
--select AmountMultipliedByTen = w.Amount * 10, w.Amount, w.* 
from WorldRecord w
where w.Category = 'speed'
/*5 
	Include the fullname of record holder in the record name, in this format - Record Name (FullName). eg Heaviest carrot (Christopher Qualley) 
*/
update w
set RecordName = w.RecordName + ' (' + w.FullName + ')'
 --select w.RecordName, w.FullName, RecordName = w.RecordName + ' (' + w.FullName + ')'
from WorldRecord w
