--to select employes deptwise
create procedure solidproc
	@deptname varchar(30)
AS 
BEGIN
	select name, Dept from dbo.Employ where  Dept = @deptname
END;
GO

EXEC solidproc
	@deptname = 'dotnet';


--to count the employs in a dept
create procedure countemploys
	@deptname varchar(30)
	
AS 
BEGIN
	select COUNT(*) as totalcount,name from dbo.Employ where Dept = @deptname
	group by name
END;
go

EXEC countemploys
	@deptname = 'dotnet'
--Create a procedure to insert a new employee record into the Employees table.
create procedure Addemploys
	@empno int,
	@name varchar(30),
	@gender varchar(30),
	@dept varchar(30),
	@design varchar(30),
	@basic numeric(9,2)
AS
BEGIN

	Insert into Employ(Empno,Name,Gender,Dept,Desig,Basic)
	values(@empno,@name,@gender,@dept,@design,@basic)
END

EXEC Addemploys 
		@empno =6,
	@name = 'pradeep',
	@gender = 'Male',
	@dept = 'Dotnet',
	@design = 'Expert',
	@basic = 80000;

create procedure Modifyemploys
	@empno int,
	@name varchar(30),
	@gender varchar(30),
	@dept varchar(30),
	@design varchar(30),
	@basic numeric(9,2)
AS
BEGIN

	update dbo.Employ
	SET
	Empno = @empno,
	Name = @name,
	Gender = @gender,
	Dept = @dept,
	Desig = @design,
	Basic = @basic	
	where Empno = @empno and
	(name!= @name or
	Gender != @gender or
	Dept != @dept or
	Desig != @design or
	Basic != @basic	);

END
EXEC Modifyemploys
		@empno =4,
	@name = 'rajesh',
	@gender = 'Male',
	@dept = 'dotnet',
	@design = 'Expert',
	@basic = 84000;


	--Create a procedure to give a bonus (add 10%) to all employees in a department.
	CREATE procedure Bonustoemploy
	@deptname varchar(30)
AS
BEGIN
		select Empno,name,Basic,basic * 1.10 bonus
		from dbo.Employ where Dept=@deptname  
		group by Empno,name,Basic order by Basic
END

exec Bonustoemploy @deptname = 'java'

--Create a procedure that deletes employees earning less than a certain amount.
create procedure DeleteEmploy
	@minsalary numeric(9,2)
AS
BEGIN
		 DELETE FROM LeaveHistory
    WHERE EmpNo IN (
        SELECT Empno FROM dbo.Employ WHERE Basic < @minSalary
    );

    -- Then delete from Employ
    DELETE FROM dbo.Employ
    WHERE Basic < @minSalary;
END

EXEC DeleteEmploy @minsalary = 83000

CREATE TABLE Employ_Insert_Log (
    Empno INT,
    Name VARCHAR(30),
    Gender VARCHAR(10),
    Dept VARCHAR(30),
    Desig VARCHAR(30),
    Basic NUMERIC(9,2),
    InsertedAt DATETIME DEFAULT GETDATE()
);

--Create a procedure to log all insert operations into a separate audit table.
CREATE PROCEDURE InsertEmployWithLog
    @Empno INT,
    @Name VARCHAR(30),
    @Gender VARCHAR(10),
    @Dept VARCHAR(30),
    @Desig VARCHAR(30),
    @Basic NUMERIC(9,2)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Insert into Employ
        INSERT INTO Employ (Empno, Name, Gender, Dept, Desig, Basic)
        VALUES (@Empno, @Name, @Gender, @Dept, @Desig, @Basic);

        -- Log the insert into audit table
        INSERT INTO Employ_Insert_Log (Empno, Name, Gender, Dept, Desig, Basic)
        VALUES (@Empno, @Name, @Gender, @Dept, @Desig, @Basic);

        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        PRINT 'Insert failed. Transaction rolled back.';
    END CATCH
END;
GO
exec InsertEmployWithLog 
		@empno = 7,
		@Name = 'john',
		@Gender = 'Male',
		@Dept = 'Java',
		@Desig = 'Manager',
		@Basic = 85000
		select * from Employ
		select * from Employ_Insert_Log

--Write a procedure using transactions that transfers an employee from one department to another
create procedure TransferDept
	@Empno int,
	@newdept varchar(30)
AS
BEGIN
	Declare @olddept varchar(30)

	BEGIN TRANSACTION
	BEGIN TRY
		SELECT @olddept = Dept from Employ where Empno = @Empno
		UPDATE Employ
		set Dept = @newdept
		where Empno = @Empno
		commit;
	END TRY
	 BEGIN CATCH
        ROLLBACK;
        PRINT 'Transfer failed. Transaction rolled back.';
    END CATCH
END;

exec TransferDept @Empno = 3,
				@newdept = 'java'
--Create a procedure with TRY…CATCH block to handle errors during salary update.
