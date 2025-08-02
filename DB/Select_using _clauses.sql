use sqlpractice
go

-- Display List of tables avaialble in current database 
select * from INFORMATION_SCHEMA.TABLES
go

-- Display information about Student Table 
sp_help Student
go

-- Dispaly all records from Emp table 
select * from Emp
go

-- Display selected feilds using alias(as) for column names

select Empno as 'Employ No', nam as 'Employ Name', basic as 'Salary'
	from Emp 
GO

--filters and based on conditions displays data
--using where clause
select * from Emp WHERE basic > 80000

select * from Emp WHERE basic < 50000
select * from Emp WHERE dept= 'java'
select * from Emp WHERE nam = 'rushi'


-- Between...AND : Display records from specific Range (works for numbers and date only) 
select * from EMP 
WHERE Basic Between 50000 and 90000
GO

select * from EMP 
WHERE Basic NOT Between 50000 and 90000
GO


-- IN Clause : Used to check for multiple values of particular column 

-- Display all records whose Dept is Java or Dotnet or Sql 

select * from Emp 
where dept in('Java','Sql')
GO

select * from Emp 
where dept NOT IN('Dotnet','Java','Sql')
GO

select * from Emp 
where nam IN('Manu','Satish','Swapna','Smitha','Rushi')
GO

-- LIKE operator : Used to display data w.r.t. wild cards

-- Display all records whose name starts with 'S'

select * from Emp where nam LIKE 'S%' 
GO

-- Display all records whose name ends with 'A' 

select * from Emp where nam LIKE '%A'
GO

-- Distinct : Eliminate duplicate entries at the time of display 

select Dept from Emp
GO

select distinct Dept from Emp 
GO
--using orderby clause for sorting acs and desc
--asecending
select * from Emp order by basic
select * from Emp order by Empno
--descending
select * from Emp order by basic desc
select * from Emp order by Empno desc
--we can apply oder by to multiple columns it filters based on priority
select * from Emp order by Dept, Nam 
GO
select * from Emp order by Nam , dept
GO

