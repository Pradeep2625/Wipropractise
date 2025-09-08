use StudentCourse

--STORED PROCEDURE TO GET STUDENT DETAILS USING STUDENTNO
create procedure sp_GET_Students
	@studentno int
AS
BEGIN
	BEGIN TRY
		IF Exists (select 1 from dbo.StudentDetails where StudentNo = @studentno)
		BEGIN
		select StudentName,Gender,City from dbo.StudentDetails where StudentNo = @studentno
		 END
        ELSE
        BEGIN
            RAISERROR('No student found with the given StudentNo.', 16, 1);
        END
	END TRY
	BEGIN CATCH
			print 'no records found'
			print ERROR_MESSAGE()
	END CATCH
END
EXEC sp_GET_Students @studentno = 102
go;
--STORED PROCEDURE TO UPDATE STUDENT DETAILS USING STUDENTNO
use StudentCourse
go
CREATE PROCEDURE SP_UPDATE_Student
	@studentno int,
	@studentname varchar(30),
	@gender varchar(10),
	@city varchar(20)
AS
BEGIN
		BEGIN TRY
		IF Exists (select 1 from dbo.StudentDetails where StudentNo = @studentno)
		BEGIN
		UPDATE dbo.StudentDetails 
		set 
		StudentName = @studentname,
		Gender = @gender,
		City = @city
		where (StudentNo = @studentno) and
		(StudentName != @studentname or
		Gender != @gender or
		City != @city);
		END
			ELSE
				BEGIN
					RAISERROR('Record not found with given studeno,.',16,25)
				END
		END TRY
			BEGIN CATCH
					Print 'record not found'
					print error_message()
			END CATCH
END

EXEC SP_UPDATE_Student @studentno = 105,
						@studentname = 'sai',
						@gender = 'Female',
						@city = 'mdp'

select * from StudentDetails

--STORED PROCEDURE TO ADD STUDENT
CREATE PROCEDURE sp_RegisterStudentToCourse
	@studentno int,
	@studentname varchar(30),
	@gender varchar(10),
	@city varchar(20)
AS
BEGIN
		BEGIN TRY
		IF Exists (select 1 from dbo.StudentDetails)
		BEGIN
		insert into StudentDetails(StudentNo,StudentName,Gender,City)
		values(@studentno,@studentname,@gender,@city)
		END
		ELSE
		BEGIN
			PRINT ('TABLE DOESNT EXIST!!')
		END
		END TRY
		BEGIN CATCH 
				print 'error is'
				print error_message()
		END CATCH
END

exec sp_RegisterStudentToCourse @studentno = 105,
								@studentname = 'sai',
								@gender = 'Female',
								@city = 'mdp'

select * from CourseDetails
--STORED PROCEDURE TO get course revenue

CREATE PROCEDURE sp_GetCourseRevenue
AS
BEGIN
    SELECT c.Coursename, COUNT(e.StudentNo) AS EnrolledStudents,
           c.Fee, SUM(c.Fee) AS TotalRevenue
    FROM Enrollments e
    JOIN CourseDetails c ON c.Ccode = e.Ccode
    GROUP BY c.Coursename, c.Fee;
END;
GO

END

EXEC sp_GetCourseRevenue
	