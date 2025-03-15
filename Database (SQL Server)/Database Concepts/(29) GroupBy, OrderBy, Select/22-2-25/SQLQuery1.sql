--22-2-25
-- A) Ordering / Sorting (ORDER BY)

-- string A-> Z  Z-> A
-- Numeric (0-@)  (@- - @) Asc Dec

Select* From Calls as c ORDER BY c.Rate -- Order Column in default (ASC)
Select* From Calls as c ORDER BY c.Rate DESC -- Order Column in (Dec)
SELECT *FROM Calls AS c ORDER BY CAST(REPLACE(c.Duration, ' mins', '') AS INT) ASC -- calls based on duration
SELECT * FROM [Caller] AS c ORDER BY c.FirstName, c.MiddleName, c.LastName -- order 2 similar datatypes columns
Select* From Calls as c ORDER BY c.Rate Desc ,c.Duration DESC -- order 2 different datatypes columns
SELECT * FROM [Caller] AS c ORDER BY (c.FirstName + c.MiddleName+ c.LastName) DESC, c.Id ASC -- when it's duplicate they will do the id in desc
SELECT * FROM [Caller] AS c ORDER BY (c.FirstName + c.MiddleName+ c.LastName) DESC, c.Id ASC -- when it's duplicate they will do the id in desc
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
select c.CallerId,AVG(c.Rate) from Calls as c group by CallerId
-- Caller information by the max rate
select CallerId,AVG(Rate) as rate from Calls  group by CallerId -- step 1 : get all caller with rate
select CallerId,AVG(Rate) as rate, Calls.IsPurches from Calls  group by CallerId, IsPurches order by rate desc -- step 2: get top caller with rate