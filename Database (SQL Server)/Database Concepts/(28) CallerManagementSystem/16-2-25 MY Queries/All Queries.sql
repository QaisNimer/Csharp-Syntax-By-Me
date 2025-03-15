-- retreive all rows and columns in selected table
select * from Admins
select * from Caller
select * from Calls
select * from CountryCode
select * from LookupItems
select * from LookupType

-- Retreive all rows with custom static column (same column in table)
select id from Admins 
select id, Name, Email from Admins 
select id, FirstName,MiddleName,LastName,PhoneNumber,Email,CreationDate from Caller

-- Retreive all row with custom column name(Alias) ????? ??? ?????? ??????? ?? ??????? ???? ?? ???? ??? ??? ????? ??? ??? ??????
select id, FirstName FN,MiddleName MN,LastName LN,PhoneNumber,Email,CreationDate from Caller
select id, FirstName as FN,MiddleName as MN,LastName as LN,PhoneNumber,Email,CreationDate from Caller -- (as) keyword is not required 
select id [My Full Id],Name as [My Full Name] from LookupItems
select C.Id , C.Title,C.Duration, c.CallerId from Calls as C -- ?????? ???? ?????? ???? ??????? ???? ???? ???? ?????? ??? ?????? ????

-- retreive all row with custom column values 
Select Name, Email, GETDATE() from Admins -- inject dynamic values (I don't have a getdate column but I inject it)
Select Name, Email, 'Act As Admin' as [role] from Admins -- inject static values (I don't have a "Act As Admin" column but I inject it)
select c.Id,(c.FirstName+' '+c.MiddleName+' '+c.LastName+' ')as [Full Name], c.Email,c.PhoneNumber from Caller as c
insert into CountryCode(Code,Sym) values ('20','MOR')
select c.Sym+'-'+CAST( c.Code as VARCHAR(MAX)) as Code from CountryCode as c -- inject using Casting (concatination)
select CONCAT(c.Code, ' - ', c.Sym) as Code from CountryCode as c -- inject using concat


-- retrieve statistics across all rows in Database
select count(*) as [COUNT] from [Calls] as c-- COUNT()	Returns the number of rows in a column (excluding NULL).
select SUM(CAST(REPLACE(c.Duration,' mins','')as int)) from Calls as c-- SUM()	Calculates the total sum of a numeric column.
select MAX(c.Duration) from Calls as c-- MAX()	Returns the largest value in a column.
select MIN(c.Duration) from Calls as c-- MIN()	Returns the smallest value in a column.
select AVG(CAST(REPLACE(c.Duration,' mins','')as int)) from Calls as c-- AVG()	Returns the average (mean) value of a numeric column.


-- LINQ (Fillteration, Sorting/ Ordering, Selection)
--1- WHERE STATEMENT
Select*from [Caller] as c where (c.PhoneNumber like'78%') -- (CONDITION) Columns and value comparison/ logicalc operations
Select*from [Caller] as c where (c.PhoneNumber like'78%' and c.LastName like '%A%') -- (CONDITION) Columns and value comparison/ logicalc operations
select * from [CountryCode] as c where (c.Code=1)


-- 2- In statement : suggest multi-values for condition
-- EXAMPLE: select first name as (khaled,omar,nada,jasser))
select * from [Caller] as c where (c.FirstName like'Khaled' or c.FirstName like'Omar' 
or c.FirstName like'Nada' or c.FirstName like'Jasser')  
-- That's not practicale so I will use IN keyword
select * from [Caller] as c where c.FirstName in( 'Khaled','Omar', 'Nada' ,'Jasser')


-- 3-between: search for numeric values in specific interval (start-end) interval bounded
-- retreve all calls duration 40-50
select* from [Calls] as c where Cast(REPLACE(c.Duration, ' mins',' ')as int) >=40 and Cast(REPLACE(c.Duration, ' mins',' ')as int)<=50
-- between
select* from [Calls] as c where Cast(REPLACE(c.Duration, ' mins',' ')as int) between 40 and 50

-- 4 IS NULL, Is Not NULL
select* from [Caller]as c where c.CountryCodeId is NULL
select* from [Caller]as c where  c.CountryCodeId Is Not Null

-- 5- Exist ---> Sub Query
-- sub query: find/ fill column in query using another query : (???? ????? ?? ????? ????? ??? ????? ????)
--EXAMPLE: return all caller with call amount
select id, (c.FirstName+' '+c.LastName) as [Full Name],c.Email,c.PhoneNumber , (select Count(*) from calls where CallerId = c.Id) as [Call Amount] from Caller as c
-- query call title, description, duration, Full Name Caller using sub query
select c.Title,c.[Description],c.Duration,(select (c.FirstName+' '+ c.LastName) as [Full Name] from [Caller] as c where id= CallerId)  from Calls as c
-- Exist(execute sub query if it have data (at least 1 row) ) then complete the query
--EXAMPLE: Return all caller info while this caller has at least one purchase
select*From [Caller]as clr
select * from Calls as c where (c.IsPurches=1)
select * from [Caller] as clr where exists (select * from Calls as c where (c.IsPurches=1 and c.CallerId= clr.Id))