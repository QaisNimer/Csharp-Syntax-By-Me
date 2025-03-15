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

--22-2-25
-- A) Ordering / Sorting (ORDER BY)

-- string A-> Z  Z-> A
-- Numeric (0-@)  (@- - @) Asc Dec

Select* From Calls as c ORDER BY c.Rate -- Order Column in default (ASC)
Select* From Calls as c ORDER BY c.Rate DESC -- Order Column in (Dec)
SELECT *FROM Calls AS c ORDER BY CAST(REPLACE(c.Duration, ' mins', '') AS INT) ASC -- calls based on duration
SELECT * FROM [Caller] AS c ORDER BY c.FirstName, c.MiddleName, c.LastName -- order 2 similar datatypes columns
Select* From Calls as c ORDER BY c.Rate Desc ,c.Duration DESC -- order 2 different datatypes columns
SELECT * FROM [Caller] AS c ORDER BY (c.FirstName + c.MiddleName+ c.LastName) DESC, c.Id DESC -- when it's duplicate they will do the id in desc
-- stored procedure use CallerId to get All Historical call by date
Create proc GetCallHisByDate(
@CallerID int) as
begin
select * from calls as c where c.CallerId=@CallerID
order by CreationDate
end
EXEC GetCallHisByDate @CallerID=11

-- B) SELECTION (Take, TakeLast, First, Last, Single, Skip Last)
-- KEYWORD: Top: Target the top rows in the result set
select TOP(5) * from Calls as c where CallerId =3 and Rate>=5
select TOP(5) * from Calls as c ORDER BY Rate DESC -- TOP 5 Calls By Rate

-- Remove Duplication : DISTINCT
select DISTINCT (c.CallerId) from Calls as c 
select distinct Top(5) c.Title, c.[Description] , c.Duration , c.CallerId from Calls as c
-- the second largest duration in calls
--1) Complex way
select distinct top(1) Duration from Calls
where duration != (Select max (duration) from Calls)
order by Duration desc
--2) Simple way : FIRST FETCH LIMIT
-- *) First (Top(1))
select top(1) * from Calls
-- *) Single(Only 1)
select * from Calls order by Id offset 0 rows -- get all element without ignore anything (offset)
select * from Calls order by Id offset 0 rows fetch next 1 rows only -- fetch: get only next n=1 record (the top record)
select * from Calls order by Id desc offset 0 rows fetch next 1 rows only -- fetch: get only next n=1 record (the last record)
select * from Calls order by Duration desc offset 1 rows fetch next 1 rows only -- second largest number
-- pagination (Page size =3)
Select* from [Caller]as c Order By c.Id offset 0 rows fetch next 3 rows only 
Select* from [Caller]as c Order By c.Id offset 3 rows fetch next 3 rows only 
Select* from [Caller]as c Order By c.Id offset 6 rows fetch next 3 rows only 
Select* from [Caller]as c Order By c.Id offset 9 rows fetch next 3 rows only 

Create proc GetAllCalls(@PageSize int,@PageIndex int)
as
begin
Select* from [Calls]as c Order By c.Id offset (@pageSize*@PageIndex) rows fetch next @PageSize rows only 
end
Exec GetAllCalls @PageSize=25,@pageIndex=0
Exec GetAllCalls @PageSize=25,@pageIndex=1

-- C) Group (group by) used in aggregation : used to merge between columns in result set and aggregation functions
select CallerId,MAX(Duration) from Calls group by CallerId
-- Avg Rate By each Call
select CallerId,AVG(Rate) from Calls group by CallerId
-- Caller information by the max rate
select CallerId,AVG(Rate) as rate from Calls  group by CallerId -- step 1 : get all caller with rate
select CallerId,AVG(Rate) as rate from Calls  group by CallerId order by rate desc -- step 2: get top caller with rate


-- 23-2-25
--1) Cross Join (bing each row result set A with all result set B)
SELECT * FROM [Caller],Calls
SELECT * FROM LookupItems,LookupType

--2) Inner Join
SELECT* FROM [Caller] JOIN Calls ON [Caller].Id=Calls.CallerId
SELECT* FROM LookupItems JOIN LookupType ON LookupItems.TypeId=LookupType.Id

--3) LEFT JOIN (Bring all records in table A and if there's any match with table B it will compine if there's nothing it will put them by NULL for B columns)
SELECT* FROM [Caller] LEFT JOIN Calls ON [Caller].Id=Calls.CallerId
SELECT* From [Caller] LEFT JOIN CountryCode ON [Caller].CountryCodeId=CountryCode.Id

--4) RIGHT JOIN (Bring all records in table A and if there's any match with table B it will compine if there's nothing Put Null for A columns)
SELECT* FROM [Caller] RIGHT JOIN Calls ON [Caller].Id=Calls.CallerId
SELECT * FROM LookupItems RIGHT JOIN LookupType ON LookupItems.TypeId = LookupType.Id
SELECT* From [Caller] RIGHT JOIN CountryCode ON [Caller].CountryCodeId=CountryCode.Id

--5) FULL JOIN (Compine between left and right join, all records of a and all records of b but if there's shared value it will make compination
--but if there's nothing between A and B shared it will be null)
SELECT* From [Caller] FULL JOIN CountryCode ON [Caller].CountryCodeId=CountryCode.Id

--6) SELF JOIN (Between the table and itself.)
SELECT* FROM Persons as p1 JOIN Persons as p2 On p1.SupervisorId=p2.Id
-- can have all of the 5.

------------------------------------------------------------------------------------------------
-- Do join between Caller - Lookup ittem (fn,ln,city)     Caller - country Code fn,ln,country sym, country code
SELECT FirstName,LastName,l.Name FROM [Caller]as c JOIN LookupItems as l  ON c.CityId=l.Id
Select c.FirstName,c.LastName,cc.Sym,cc.Code from Caller as c join CountryCode as cc on c.CountryCodeId = cc.Id	
-- multi-tables joining: joining between the result set (single table or 2 joined table with another table)
select *from [Caller] as c join LookupItems as li on c.CityId= li.Id join CountryCode as cc on c.CountryCodeId=cc.Id
--------------------------------------------------------------------------------------------------
-- SQL Operators: JOIN KEYWORDS (Union , Intersect, Except).
-- extract result from same executed query.
-- result set A,B MOSTLY HAVE THE SAME RESULT SET STRUCTURE.
--1) Union: Combines results from two queries and removes duplicates.
select c.FirstName,c.LastName from Caller as c
union
select c.FirstName,c.LastName from Caller as c where c.Id>5
-- same as union but with duplication
select c.FirstName,c.LastName from Caller as c
union all
select c.FirstName,c.LastName from Caller as c where c.Id>5

--2) Intersect : Returns only common rows found in both queries.
select c.FirstName,c.LastName from Caller as c where c.Id >8
Intersect
select c.FirstName,c.LastName from Caller as c where c.Id>5
--3) Except : Returns rows from the first query that are not in the second.
select c.FirstName,c.LastName from Caller as c where c.Id >3
Except
select c.FirstName,c.LastName from Caller as c where c.Id>5
