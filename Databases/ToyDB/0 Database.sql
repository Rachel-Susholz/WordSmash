--AS Great job! 100%
/*
    You buy toys wholesale from China and sell to local toy stores. 
    You are trying to organize your inventory, and create a system to track how much you are spending and earning.
*/

-- 1. Create a database called ToyDB
create database ToyDB 

/* 2. Create a table called Toy to store the data. 
      This is the information that needs to be recorded: 
		name of the toy, item number, the purchase price per unit, date purchased, quantity purchased, sold (true or false), price per unit sold, date sold.
	  Note that in this business the entire stock of each toy is sold together, so we do not need to record the quantity sold.
	  Note that the maximum price for a toy purchased and sold is $9999.99

*/
use ToyDB
go 
drop table if exists Toy
go 
create table dbo.Toy(
    ToyID int not null identity primary key,
    Toy varchar (50),
    ItemNum varchar (5),
    PurchasePrice decimal (6,2),
    DatePurchased date,
    Quantity int,
    Sold bit, 
    SellPrice decimal (6,2),
    DateSold date
)
go
/* 3. Populate the table with sample data. 
      Add the following toys and then add two more of your own:
      Baby Doll, item number - 12389, bought 500 for $12 each on Jan 15 2021, sold for $20 each on Feb 19 2021
      Monopoly, item number - 25678, bought 1000 for $15 each on Feb 9 2021, sold on April 18 2021 for $22 each 
      Fire Truck, item number - 89076, bought 250 for $5 each on Jan 9 2020, sold on Feb 8 2021 for $15 each 
      Lego Police Station, item number - 09865, bought 400 for $20 each on October 9 2021, sold for $40 each on Oct 12 2021
      Silly Putty, item number - 87645, bought 1000 for $0.25 each on Oct 15 2021, sold for $1 on Oct 19 2021
      Playmobil Hospital, item number - 98234, bought 50 for $30 each on Sept 8 2019, sold on Oct 1 2019 for $50 each 
      Doll House, item number - 23897, bought 300 for $18 each on Sept 7 2021, not sold yet
      Basketball, item number - 36098, bought 500 for $5 each on Feb 9 2021, not sold yet   
*/
insert toy(Toy, ItemNum, PurchasePrice, DatePurchased, Quantity, Sold, SellPrice, DateSold)
select 'Baby Doll', 12389, 12, '01-15-2021', 500, 1, 20, '02-19-2021'
union select 'Monopoly', 25678, 15, '02-09-2021', 1000, 1, 22, '04-18-2021' 
union select 'Fire Truck', 89076, 5, '01-09-2020', 250, 1, 15, '02-08-2021' 
union select 'Lego Police Station', 09865, 20, '10-09-2021', 400, 1, 40, '10-12-2021'
union select 'Silly Putty', 87645, .25, '10-15-2021', 1000, 1, 1, '10-19-2021'
union select 'Playmobil Hospital', 98234, 30, '03-08-2019', 50, 1, 50, '10-01-2019'
union select 'Doll House', 23897, 18, '03-07-2021', 300, 0, null, null
union select 'Basketball', 36098, 5, '02-09-2021', 500, 0, null, null 
union select 'MagnaTiles', 54808, 25,'04-06-2021', 600, 0, null, null
union select 'Kliks', 67903, 45, '09-04-2021', 400, 0, null, null
      
-- 4. Show a list of toys sorted by quantity purchased, exclude toys not sold at all
select * 
from toy t
where t.Sold <> 0
order by t.Quantity 
-- 5. Show the top 4 toys that were sold for at least five dollars more per unit than they were purchased for. Display the profit as well
select top (4) *, Profit = t.SellPrice - t.PurchasePrice 
from toy t 
where t.SellPrice - t.PurchasePrice > 5
order by Profit desc
-- 6. Show a new column called SoldOrNot. For any toys that have not sold at all, display the words unsold, otherwise display the price the toy sold for.
select *, SoldOrNot = isnull (convert(varchar,sellprice), 'unsold')
from toy t 
/* 7. Show how many days each toy sat in the warehouse until it was sold, ordered by fastest selling to slowest selling.
      If it is still in stock show how long it has been gathering dust for.
      Use two SQL statements. 
*/
select *, DaysInWarehouse = datediff(day, t.DatePurchased, t.DateSold)
from toy t
where t.Sold <> 0
order by DaysInWarehouse

select *, DaysInWarehouse = DateDiff(day, t.DatePurchased, current_timestamp)
from toy t
where t.Sold = 0
/* 8. A new worker recently joined your staff and made two mistakes in logging the inventory:
        1.  Baseballs, not basketballs were bought for $5 each on Feb 9 2021
        2.  There was never any Silly Putty bought or sold by your company.
     Correct the data using two SQL statements.
*/
--1)
update t
set t.toy = 'Baseball'
--select *
from toy t
where t.toy = 'Basketball'
and t.DatePurchased = '02-09-2021'
--2)
delete t 
from toy t 
where t.Toy = 'Silly Putty'
