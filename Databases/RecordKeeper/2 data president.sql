--AS 100% session 23
--AS 100% session 24 perfect job!
use RecordKeeperDB

delete executiveorders  
delete president
delete party 
delete color


insert Color(Color)
select 'Red'
union select 'Blue'
union select 'Orange'
union select 'Yellow'
union select 'White'
union select 'Green'
union select 'Purple'
union select 'Black'
go

insert party(PartyName, YearFormed, ColorId)
select 'Republican', 1854,  (select c.ColorId from color c where c.Color = 'Red')
union select 'Democrat', 1828, (select c.ColorId from color c where c.Color = 'Blue')
union select 'Federalist', 1791, (select c.ColorId from color c where c.Color = 'Orange') 
union select 'Whig', 1833, (select c.ColorId from color c where c.Color = 'Yellow')
union select 'None,Federalist', 1789, (select c.ColorId from color c where c.Color = 'White')
union select 'National Union', 1864, (select c.ColorId from color c where c.Color = 'Green')
union select 'Democratic-Republican',1792, (select c.ColorId from color c where c.Color = 'Purple')
union select 'Black Panther', 1966, (select c.ColorId from color c where c.Color = 'Black')
union select 'Socialist Party of America', 1901, null
union select 'Prohibition', 1869, (select c.ColorId from color c where c.Color = 'Red')
go

insert president(PartyId, Num, FirstName, LastName, DateBorn, DateDied, TermStart, TermEnd)
select r.PartyId, 1, 'George', 'Washington', '1732-02-22', '1799-12-14', 1789, 1797 from party r where r.PartyName = 'None,Federalist'
union select r.PartyId, 2, 'John', 'Adams', '1735-10-30', '1826-07-04', 1797, 1801 from party r where r.PartyName = 'Federalist'
union select r.PartyId, 3, 'Thomas', 'Jefferson', '1743-04-13', '1826-07-04', 1801, 1809 from party r where r.PartyName = 'Democratic-Republican'
union select r.PartyId, 4, 'James', 'Madison', '1751-03-16', '1836-06-28', 1809, 1817 from party r where r.PartyName = 'Democratic-Republican'
union select r.PartyId, 5, 'James', 'Monroe', '1758-04-28', '1831-07-04', 1817, 1825 from party r where r.PartyName = 'Democratic-Republican'
union select r.PartyId, 6, 'John Quincy', 'Adams', '1767-07-11', '1848-02-23', 1825, 1829 from party r where r.PartyName = 'Democratic-Republican'
union select r.PartyId, 7, 'Andrew', 'Jackson', '1767-03-15', '1845-06-08', 1829, 1837 from party r where r.PartyName = 'Democrat'
union select r.PartyId, 8, 'Martin', 'van Buren', '1782-12-05', '1862-07-24', 1837, 1841 from party r where r.PartyName = 'Democrat'
union select r.PartyId, 9, 'William H.', 'Harrison', '1773-02-09', '1841-04-04', 1841, 1841 from party r where r.PartyName = 'Whig'
union select r.PartyId, 10, 'John', 'Tyler', '1790-03-29', '1862-01-18', 1841, 1845 from party r where r.PartyName = 'Whig'
union select r.PartyId, 11, 'James K.', 'Polk', '1795-11-02', '1841-06-15', 1845, 1849 from party r where r.PartyName = 'Democrat'
union select r.PartyId, 12, 'Zachary', 'Taylor', '1784-11-24', '1850-07-09', 1849, 1850 from party r where r.PartyName = 'Whig'
union select r.PartyId, 13, 'Millard', 'Fillmore', '1800-01-07', '1874-03-08', 1850, 1853 from party r where r.PartyName = 'Whig'
union select r.PartyId, 14, 'Franklin', 'Pierce', '1804-11-23', '1869-10-08', 1853, 1857 from party r where r.PartyName = 'Democrat'
union select r.PartyId, 15, 'James', 'Buchanan', '1791-04-23', '1868-06-01', 1857, 1861 from party r where r.PartyName = 'Democrat'
union select r.PartyId, 16, 'Abraham', 'Lincoln', '1809-02-12', '1865-04-15', 1861, 1865 from party r where r.PartyName = 'Republican'
union select r.PartyId, 17, 'Andrew', 'Johnson', '1808-12-29', '1875-07-31', 1865, 1869 from party r where r.PartyName = 'National Union'
union select r.PartyId, 18, 'Ulysses S.', 'Grant', '1822-04-27', '1885-07-23', 1869, 1877 from party r where r.PartyName = 'Republican'
union select r.PartyId, 19, 'Rutherford', 'Hayes', '1822-10-04', '1893-01-17', 1877, 1881 from party r where r.PartyName = 'Republican'
union select r.PartyId, 20, 'James', 'Garfield', '1831-11-19', '1881-09-19', 1881, 1881 from party r where r.PartyName = 'Republican'
union select r.PartyId, 21, 'Chester', 'Arthur', '1829-10-05', '1886-11-18', 1881, 1885 from party r where r.PartyName = 'Republican'
union select r.PartyId, 22, 'Grover', 'Cleveland', '1837-03-18', '1908-06-24', 1885, 1889 from party r where r.PartyName = 'Democrat'
union select r.PartyId, 23, 'Benjamin', 'Harrison', '1833-08-20', '1901-03-13', 1889, 1893 from party r where r.PartyName = 'Republican'
union select r.PartyId, 24, 'Grover', 'Cleveland', '1837-03-18', '1908-06-24', 1893, 1897 from party r where r.PartyName = 'Democrat'
union select r.PartyId, 25, 'William', 'McKinley', '1843-01-29', '1901-09-14', 1897, 1901 from party r where r.PartyName = 'Republican'
union select r.PartyId, 26, 'Theodore', 'Roosevelt', '1858-10-27', '1919-01-06', 1901, 1909 from party r where r.PartyName = 'Republican'
union select r.PartyId, 27, 'William', 'Taft', '1857-09-15', '1930-03-08', 1909, 1913 from party r where r.PartyName = 'Republican'
union select r.PartyId, 28, 'Woodrow', 'Wilson', '1856-12-28', '1924-02-03', 1913, 1921 from party r where r.PartyName = 'Democrat'
union select r.PartyId, 29, 'Warren', 'Harding', '1865-11-02', '1923-08-02', 1921, 1923 from party r where r.PartyName = 'Republican'
union select r.PartyId, 30, 'Calvin', 'Coolidge', '1872-07-04', '1933-01-05', 1923, 1929 from party r where r.PartyName = 'Republican'
union select r.PartyId, 31, 'Herbert C.', 'Hoover', '1874-08-10', '1964-10-20', 1929, 1933 from party r where r.PartyName = 'Republican'
union select r.PartyId, 32, 'Franklin Delano', 'Roosevelt', '1882-01-30', '1945-04-12', 1933, 1945 from party r where r.PartyName = 'Democrat'
union select r.PartyId, 33, 'Harry S', 'Truman', '1884-05-08', '1972-12-26', 1945, 1953 from party r where r.PartyName = 'Democrat'
union select r.PartyId, 34, 'Dwight David', 'Eisenhower', '1890-10-14', '1969-03-28', 1953, 1961 from party r where r.PartyName = 'Republican'
union select r.PartyId, 35, 'John Fitzgerald', 'Kennedy', '1917-05-29', '1963-11-22', 1961, 1963 from party r where r.PartyName = 'Democrat'
union select r.PartyId, 36, 'Lyndon Baines', 'Johnson', '1908-08-27', '1973-01-22', 1963, 1969 from party r where r.PartyName = 'Democrat'
union select r.PartyId, 37, 'Richard Milhous', 'Nixon', '1913-01-09', '1994-04-22', 1969, 1974 from party r where r.PartyName = 'Republican'
union select r.PartyId, 38, 'Gerald R.', 'Ford', '1913-07-14', '2006-12-26', 1974, 1977 from party r where r.PartyName = 'Republican'
union select r.PartyId, 39, 'James Earl', 'Carter', '1924-10-01', null, 1977, 1981 from party r where r.PartyName = 'Democrat'
union select r.PartyId, 40, 'Ronald Wilson', 'Reagan', '1911-02-06', '2004-06-05', 1981, 1989 from party r where r.PartyName = 'Republican'
union select r.PartyId, 41, 'George H. W.', 'Bush', '1924-06-12', '2018-11-30', 1989, 1993 from party r where r.PartyName = 'Republican'
union select r.PartyId, 42, 'William Jefferson', 'Clinton', '1946-08-19', null, 1993, 2001 from party r where r.PartyName = 'Democrat'
union select r.PartyId, 43, 'George W.', 'Bush', '1946-07-06', null, 2001, 2009 from party r where r.PartyName = 'Republican'
union select r.PartyId, 44, 'Barack', 'Obama', '1961-08-04', null, 2009, 2017 from party r where r.PartyName = 'Democrat'
go

insert ExecutiveOrders (PresidentId, OrderNumber, VolumeNumber, OrderCode, PageNumber, IssueYear, OrderName, OrderStatus)
select p.PresidentId, 13765, '3', 'C.F.R.', 182, 1789, 'Comprehensive Plan for Reorganizing the Executive Branch', 1 from president p where p.Num = 1
union select p.PresidentId, 13535, '3', 'C.F.R.', 458, 1864, 'Establishing a Coordinated Government-wide Initiative to Promote Diversity and Inclusion in the Federal Workforce', 1 from president p where p.Num = 17
union select p.PresidentId, 13603, '3', 'C.F.R.', 599, 1833, 'National Defense Resources Preparedness', 1 from president p where p.Num = 2
union select p. PresidentId, 13473, '3', 'C.F.R.', 679, 1833, 'United States Postal Service', 1 from president p where p.Num = 2
union select p. PresidentId, 13489, '3', 'C.F.R.', 987, 1789, 'Ethics Commitments by Executive Branch Personnel', 1 from president p where p.Num = 1
union select p. PresidentId, 13494, '3', 'C.F.R.', 785, 1789, 'Ordering the Selected Reserve and Certain Individual Ready Reserve Members of the Armed Forces to Active Duty', 1 from president p where p.Num = 1
go



