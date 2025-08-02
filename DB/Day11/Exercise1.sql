select *
from dbo.tblPayEmployees
-- Write a query to Get a List of Employees who have a one part name
select Name 
from dbo.tblEmployees
where Name not like '% %'

--Write a query to Get a List of Employees who have a three part name
SELECT Name
FROM dbo.tblEmployees
WHERE LEN(Name) - LEN(REPLACE(Name, ' ', '')) = 2;

--write a query to get a list of Employees who have a First Middle Or last name as Ram, and not any thing else
SELECT Name
FROM dbo.tblEmployees
WHERE Name like  'ram[ ]%' or Name like '%[ ]ram' or Name like '%[ ]ram[ ]%'
--
--Write the answers for  the Below
--65 OR 11
select name,EmployeeNumber,CategoryCode 
from dbo.tblEmployees where CategoryCode = 11 or CategoryCode = 65

--65 XOR 11
select name ,EmployeeNumber,CategoryCode ,CentreCode
from dbo.tblEmployees where (CategoryCode = 11 and CentreCode <> 65) or (CategoryCode = 65 and CentreCode <> 11)
--65 AND 11
select name ,EmployeeNumber,CategoryCode ,CentreCode
from dbo.tblEmployees where CategoryCode = 65 and CentreCode =11
--(12 AND 4) OR ( 13 AND 1)
select name ,EmployeeNumber,CategoryCode ,CentreCode
from dbo.tblEmployees where (CategoryCode = 12 and CentreCode = 4) or (CategoryCode = 13 and CentreCode = 1)
--127  OR  64
select name ,EmployeeNumber,CategoryCode ,CentreCode
from dbo.tblEmployees where CategoryCode = 127 or CentreCode =64
--127  XOR 64
select count (*)
from dbo.tblEmployees where (CategoryCode = 127 and CentreCode <> 64) or (CategoryCode = 127 and CentreCode <> 64)
--127 XOR 128
select name ,EmployeeNumber,CategoryCode ,CentreCode
from dbo.tblEmployees where (CategoryCode = 127 and CentreCode =128)
--127 AND 64

select name ,EmployeeNumber,CategoryCode ,CentreCode
from dbo.tblEmployees where (CategoryCode = 127 and CentreCode =64)

--127 AND 128

select name ,EmployeeNumber,CategoryCode ,CentreCode
from dbo.tblEmployees where (CategoryCode = 128 and CentreCode =127)

-- Write a query which returns data in all columns from the table dbo.tblCentreMaster
select * from dbo.tblCentreMaster

--Write a query which gives employee types in the organization
select name,EmployeeType from dbo.tblEmployees

--Write a query which returns Name, FatherName, DOB of employees whose PresentBasic is
--a.      Greater than 3000.
select Name,FatherName,DOB
from dbo.tblEmployees where PresentBasic > 3000

--b.      Less than 3000.
select Name,FatherName,DOB
from dbo.tblEmployees where PresentBasic < 3000

--c.      Between 3000 and 5000.
select Name,FatherName,DOB
from dbo.tblEmployees where PresentBasic Between  3000 and 5000

--Write a query which returns All the details of employees whose Name
--a.      Ends with 'KHAN'
select * from dbo.tblEmployees where right((name),4) like 'KHAN'

--b.      Starts with 'CHANDRA'
select * from dbo.tblEmployees where left((name),7) like 'CHANDRA'
--c.      Is 'RAMESH' and their initial will be in the rage of alphabets a-t.
select name
from dbo.tblEmployees where name like '[a-t][.]ramesh'
