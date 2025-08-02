--Write a query to get Total Present basic  for all departments where total Present basic is greater than 30000, 
--data should be sorted by department
select DepartmentCode,sum(presentBasic) as total_basic
from dbo.tblEmployees
group by DepartmentCode
having sum(PresentBasic)> 30000 order by DepartmentCode

--Write a query to Get Max , Min and Average age of employees by service Type , 
--Service Status for each Centre (display in years and Months)
select ServiceStatus,CentreCode,ServiceType,
CONVERT(varchar(10),MAX(DATEDIFF(MM,DOB,GETDATE())/12))+'years '+
CONVERT(varchar(10),MAX(DATEDIFF(MM,DOB,GETDATE())%12))+'months' as MAX_AGE,
CONVERT(varchar(10),MIN(DATEDIFF(MM,DOB,GETDATE())/12))+'years '+
CONVERT(varchar(10),MIN(DATEDIFF(MM,DOB,GETDATE())%12))+'months' as MIN_AGE,            
CONVERT(varchar(10),AVG(DATEDIFF(MM,DOB,GETDATE())/12))+'years '+
CONVERT(varchar(10),AVG(DATEDIFF(MM,DOB,GETDATE())%12))+'months' as AVG_AGE
from dbo.tblEmployees
group by ServiceStatus,ServiceType, CentreCode
order by ServiceStatus,ServiceType, CentreCode

--write a query to Get Max , Min and Average service of employees by service Type , 
--Service Status for each Centre (display in years and Months)
select ServiceType,ServiceStatus,CentreCode,
CONVERT(varchar(10),MAX(DATEDIFF(MM,DOJ,GETDATE())/12))+'years '+
CONVERT(varchar(10),MAX(DATEDIFF(MM,DOJ,GETDATE())%12))+'months' as MAX_service,
CONVERT(varchar(10),MIN(DATEDIFF(MM,DOJ,GETDATE())/12))+'years '+
CONVERT(varchar(10),MIN(DATEDIFF(MM,DOJ,GETDATE())%12))+'months' as MIN_service,            
CONVERT(varchar(10),AVG(DATEDIFF(MM,DOJ,GETDATE())/12))+'years '+
CONVERT(varchar(10),AVG(DATEDIFF(MM,DOJ,GETDATE())%12))+'months' as AVG_service
from dbo.tblEmployees
group by ServiceStatus,ServiceType, CentreCode
order by ServiceStatus,ServiceType, CentreCode

--Select all departments where Total Salary of a Department is Greater than thrice the Average Salary for the department
select DepartmentCode,sum(PresentBasic) 
from dbo.tblEmployees group by DepartmentCode having sum(PresentBasic) > AVG(PresentBasic) * 3

--Select all departments where Total Salary of a Department is Greater than twice the Average Salary for the department. 
--And max basic for the department is at least thrice the Min basic for the department
select DepartmentCode,sum(PresentBasic) 
from dbo.tblEmployees group by DepartmentCode having sum(PresentBasic) > AVG(PresentBasic) * 2 and  
max(PresentBasic) >= (3*min(presentbasic))

--Select all the centers where max Length of the employee  name is twice the min length of the employee name
select CentreCode
from dbo.tblEmployees group by CentreCode having max(len(name)) = 2 * min(len(name)) 

--write a query to Get Max , Min and Average service of employees by service Type , Service Status for each Centre 
--(display in mille seconds)
select ServiceType,ServiceStatus,CentreCode,
MAX(DATEDIFF(HH,DOJ,GETDATE())) as MAX_SEVICE ,                        
MIN(DATEDIFF(HH,DOJ,GETDATE())) as MIN_SEVICE,            
AVG(DATEDIFF(HH,DOJ,GETDATE())) as AVG_SEVICE   
from dbo.tblEmployees
group by ServiceStatus,ServiceType, CentreCode
order by ServiceStatus,ServiceType, CentreCode

--write a query to find out employees whose names have Leading or Trailing spaces
SELECT name
FROM dbo.tblEmployees
WHERE name LIKE ' %' OR name LIKE '% ';

--write a query to find out employees who have more than one space between two parts of 
--the Name. (previous query (14) Out is Key clue in getting this query right)
SELECT name
FROM dbo.tblEmployees
WHERE name LIKE '%[a-z]%  %[a-z]%';  -- Two consecutive spaces
--.   Write a Query to display employee names  by removing all trailing and Leading Spaces , if the names have ‘.’  
--Or multiple spaces between the names than the data should be processed to display only one space.


SELECT LTRIM(RTRIM(REPLACE(REPLACE(REPLACE(name,' ',''),'  ',' '),'.',' ')))
FROM dbo.tblEmployees

--write a query to find out Max Number of words in all the employee Names . 
--(Clue Previous queries expressions as input to the Current Query )
select DummyTable.FormatedName,LEN(DummyTable.FormatedName)-LEN(REPLACE(DummyTable.FormatedName,' ',''))+1
from 
    (
        select LTRIM(RTRIM(REPLACE(REPLACE(REPLACE(REPLACE(emp.Name,'.',' '),' ',' %'),'% ',''),'%','') )) FormatedName                            
        from dbo.tblEmployees emp
    )DummyTable

    --Write a Query to List all employees whose name Starts and Ends with the same Character 
 SELECT DummyTable.FormatedName as name
FROM (
               select LTRIM(RTRIM(REPLACE(REPLACE(REPLACE(REPLACE(emp.Name,'.',' '),' ',' %'),'% ',''),'%','') )) FormatedName                            
               from dbo.tblEmployees emp
            )DummyTable where (left((DummyTable.FormatedName),1)) = (right((DummyTable.FormatedName),1))

--Write a Query to List all employees whose First and Second name Starts with the same Character
 SELECT DummyTable.FormatedName as name
FROM (
               select LTRIM(RTRIM(REPLACE(REPLACE(REPLACE(REPLACE(emp.Name,'.',' '),' ',' %'),'% ',''),'%','') )) FormatedName                            
               from dbo.tblEmployees emp
            )DummyTable where LEFT(DummyTable.FormatedName,1)=SUBSTRING(DummyTable.FormatedName,PATINDEX('%[ ]%',DummyTable.FormatedName)+1,1)        
       AND DummyTable.FormatedName LIKE '%[A-Z]%[ ][A-Z]%'; 
--Write a Query to List all employees whose First Character of all the words in the name starts with the same Character
SELECT name
FROM dbo.tblEmployees
WHERE 
    -- Ensure name has at least two words
    LEN(name) - LEN(REPLACE(LTRIM(RTRIM(name)), ' ', '')) >= 1
    AND
    -- Extract first letter of each word and compare
    UPPER(LEFT(LTRIM(name), 1)) = 
        UPPER(SUBSTRING(name, CHARINDEX(' ', name) + 1, 1))
    AND
    (
        -- If third word exists, compare it too
        LEN(name) - LEN(REPLACE(name, ' ', '')) < 2
        OR UPPER(LEFT(LTRIM(name), 1)) = 
           UPPER(SUBSTRING(name, CHARINDEX(' ', name, CHARINDEX(' ', name) + 1) + 1, 1))
    );

--Write a query to list out all the employees where any of the words (Excluding Initials ) in the 
--Name starts and ends with the same character.
SELECT DummyTable.FormatedName as name
FROM (
               select LTRIM(RTRIM(REPLACE(REPLACE(REPLACE(REPLACE(emp.Name,'.',' '),' ',' %'),'% ',''),'%','') )) FormatedName                            
               from dbo.tblEmployees emp
        )DummyTable where (left((DummyTable.FormatedName),1)) = (right((DummyTable.FormatedName),1))

--Write a Query to List out all employees where the present basic is perfectly rounded of to 100.
select name,presentbasic
from dbo.tblEmployees  where ROUND(PresentBasic,-2)=PresentBasic AND PresentBasic<>0; 

select emp.Name,emp.PresentBasic 
from dbo.tblEmployees emp
where FLOOR(emp.PresentBasic/100)=(emp.PresentBasic/100) AND emp.PresentBasic<>0;

select emp.Name,emp.PresentBasic 
from dbo.tblEmployees emp
where (emp.PresentBasic%100)=0 AND emp.PresentBasic<>0;

select emp.Name,emp.PresentBasic 
from dbo.tblEmployees emp
where CEILING(emp.PresentBasic/100)=(emp.PresentBasic/100) AND emp.PresentBasic<>0;

select Name,DOB, DOJ DateOfJoining, 
DATEADD(DAY,15,DATEADD(MONTH,3,DATEADD(YEAR,1,DOJ))) as EligibleDate,
DATEADD(MONTH,1,DATEADD(DAY,-(DATEPART(dd,DATEADD(DAY,15,DATEADD(MONTH,3,DATEADD(YEAR,1,DOJ))))-1),DATEADD(DAY,15,DATEADD(MONTH,3,DATEADD(YEAR,1,DOJ)))))As BonusDate,
CONVERT(varchar(max),(DATEDIFF(MONTH,DOB,DATEADD(MONTH,1,DATEADD(DAY,-(DATEPART(dd,DATEADD(DAY,15,DATEADD(MONTH,3,DATEADD(YEAR,1,DOJ))))-1),DATEADD(DAY,15,DATEADD(MONTH,3,DATEADD(YEAR,1,DOJ))))))/12))+' years '+
CONVERT(varchar(max),(DATEDIFF(MONTH,DOB,DATEADD(MONTH,1,DATEADD(DAY,-(DATEPART(dd,DATEADD(DAY,15,DATEADD(MONTH,3,DATEADD(YEAR,1,DOJ))))-1),DATEADD(DAY,15,DATEADD(MONTH,3,DATEADD(YEAR,1,DOJ))))))%12))+' Months',
DATENAME(dw,DATEADD(DAY,15,DATEADD(MONTH,3,DATEADD(YEAR,1,DOJ))))As WeekDayName,
DATENAME(Wk,DATEADD(DAY,15,DATEADD(MONTH,3,DATEADD(YEAR,1,DOJ))))As WeekOfYear,
DATENAME(dy,DATEADD(DAY,15,DATEADD(MONTH,3,DATEADD(YEAR,1,DOJ))))As DayOfYears,
(DATENAME(DD,DATEADD(DAY,15,DATEADD(MONTH,3,DATEADD(YEAR,1,DOJ))))/7)+1 As WeekOfMonth         
from dbo.tblEmployees

SELECT EmployeeNumber ,name, ServiceType, EmployeeType, DOJ, Dob
FROM dbo.tblEmployees
WHERE (
    -- Service Type 1: Employee Type 1
    ServiceType = 1 AND EmployeeType = 1 AND
    DATEDIFF(YEAR, Doj, GETDATE()) >= 10 AND
    (60 - DATEDIFF(YEAR, Dob, GETDATE())) >= 15
)
OR (
    -- Service Type 1: Employee Type 2
    ServiceType = 1 AND EmployeeType = 2 AND
    DATEDIFF(YEAR, Doj, GETDATE()) >= 12 AND
    (55 - DATEDIFF(YEAR, Dob, GETDATE())) >= 14
)
OR (
    -- Service Type 1: Employee Type 3
    ServiceType = 1 AND EmployeeType = 3 AND
    DATEDIFF(YEAR, Doj, GETDATE()) >= 12 AND
    (55 - DATEDIFF(YEAR, Dob, GETDATE())) >= 12
)
OR (
    -- Service Type 2, 3, 4
    ServiceType IN (2, 3, 4) AND
    DATEDIFF(YEAR, Doj, GETDATE()) >= 15 AND
    (65 - DATEDIFF(YEAR, Dob, GETDATE())) >= 20
);

--Write a query to display the currentdate in all possible formats using convert function
select GETDATE() 
GO

select convert(varchar,GETDATE(),1) 
Go

select convert(varchar,GETDATE(),2) 
Go

select convert(varchar,GETDATE(),101) 
Go

select convert(varchar,GETDATE(),103) 
Go

--write a query to find out all the employees who has the net payment 
--less than the actual basic that he should have earned,  in any of the payments
SELECT DISTINCT EmployeeNumber, NoteNumber, ActualGrossPay, NetPay
FROM dbo.tblPayEmployees
WHERE NetPay < ActualGrossPay
  AND ActualGrossPay > 0;




 
