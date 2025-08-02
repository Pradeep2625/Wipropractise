select * from	Agent
go
select * from AgentPolicy
go
--Display Last Occurrence of given char in a string
SELECT 
  LEN('Charishma Gada') - CHARINDEX('a', REVERSE('Charishma Gada')) + 1 AS LastOccurrence;
GO

--Take FullName as 'Venkata Narayana' and split them into firstName and LastName
SELECT FullName,
  LEFT(FullName, CHARINDEX(' ', FullName) - 1) AS FirstName,
  SUBSTRING(FullName, CHARINDEX(' ', FullName) + 1, LEN(FullName)) AS LastName
FROM Agent
WHERE CHARINDEX(' ', FullName) > 0

-- In Word 'misissipi' count no.of 'i' 
SELECT 
  LEN('misissipi') -LEN(REPLACE('misissipi','i','')) as i_count
--Display the last day of next month
SELECT EOMONTH(DATEADD(MONTH, 1, GETDATE())) AS LastDayOfNextMonth;
--Display First Day of Previous Month
SELECT DATEFROMPARTS(year(DATEADD(MONTH,  -1, GETDATE())), MONTH(DATEADD(MONTH, -1, GETDATE())),1) AS FirstDayOfPreviousMonth;
--Display all Fridays of current month
CREATE TABLE Calendar (
    CalendarDate DATE
);

INSERT INTO Calendar (CalendarDate)
SELECT DATEADD(DAY, number, '2025-08-01')
FROM master..spt_values
WHERE type = 'P' AND number BETWEEN 0 AND 30;
select * from Calendar;
SELECT CalendarDate
FROM Calendar
WHERE DATENAME(WEEKDAY, CalendarDate) = 'Friday';



    
