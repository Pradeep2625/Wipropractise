

create Database StudentCourse
go
use StudentCourse

create table CourseDetails
(
	Ccode VARCHAR(10) PRIMARY KEY not null,
	Coursename VARCHAR(100) not null,
	Duration VARCHAR(20),
	Fee DECIMAL(10,2) not null
)
INSERT INTO CourseDetails(Ccode, Coursename, Duration, Fee) VALUES
('C001', 'Python Basics', '2 Months', 5000.00),
('C002', 'Web Development', '3 Months', 7500.00),
('C003', 'Java Programming', '4 Months', 9000.00);


create table StudentDetails
(
	StudentNo int primary key not null,
	StudentName varchar(30) not null,
	City varchar(20),
	Gender varchar (10) constraint chk_gender check (gender in ('Male','Female'))
)
INSERT INTO StudentDetails(StudentNo, StudentName, City, Gender) VALUES
(101, 'Amit Verma', 'Delhi', 'Male'),
(102, 'Sneha Rao', 'Mumbai', 'Female'),
(103, 'Rahul Mehta', 'Chennai', 'Male'),
(104, 'Priya Nair', 'Kochi', 'Female');


create table FacultyDetails
(
	FacultyCode varchar(10) primary key not null,
	FacultyName varchar(20) not null,
	Qualification varchar(10)
)
INSERT INTO FacultyDetails (FacultyCode, FacultyName, Qualification) VALUES
('F01', 'Ravi Kumar', 'M.Tech'),
('F02', 'Meera Sharma', 'Ph.D'),
('F03', 'Kunal Das', 'MCA');

create table PaymentDetails
(
	PaymentId int Primary key not null,
	PaymentDate date not null,
	StudentNo int foreign key references StudentDetails(StudentNo)
)
INSERT INTO PaymentDetails (PaymentId, StudentNo, PaymentDate) VALUES
(201, 101, '2025-08-02'),
(202, 102, '2025-08-03'),
(203, 103, '2025-08-05'),
(204, 104, '2025-08-07');

create table Batch
(
	BatchCode varchar(10) primary key not null,
	BatchName varchar(20),
	startDate date not null,
	EndDate date not null,
	Timing varchar(20)
)
INSERT INTO Batch (BatchCode, BatchName, StartDate, EndDate, Timing) VALUES
('B01', 'Morning Batch', '2025-08-01', '2025-10-01', '8 AM-10 AM'),
('B02', 'Evening Batch', '2025-08-10', '2025-11-10', '6 PM-8 PM'),
('B03', 'Weekend Batch', '2025-08-15', '2025-12-15', 'Sat-Sun 10 AM');

	
Create TABLE Enrollments 
(
  StudentNo INT,
  Ccode VARCHAR(10),
  FacultyCode VARCHAR(10),
  BatchCode VARCHAR(10),
  PRIMARY KEY (StudentNo, Ccode, BatchCode),
  FOREIGN KEY (StudentNo) REFERENCES StudentDetails(StudentNo),
  FOREIGN KEY (Ccode) REFERENCES CourseDetails(Ccode),
  FOREIGN KEY (FacultyCode) REFERENCES FacultyDetails(FacultyCode),
  FOREIGN KEY (BatchCode) REFERENCES Batch(BatchCode)
);
INSERT INTO Enrollments (StudentNo, Ccode, FacultyCode, BatchCode) VALUES
(101, 'C001', 'F01', 'B01'),
(102, 'C002', 'F02', 'B02'),
(103, 'C003', 'F01', 'B01'),
(104, 'C001', 'F03', 'B03');

--validationg normalization using joins
select s.StudentName,s.StudentNo,s.Gender,s.City,c.Ccode,c.Coursename,c.Duration,c.Fee,
f.FacultyCode,f.FacultyName,f.Qualification,b.BatchCode,b.BatchName,b.EndDate,b.startDate,b.Timing,
p.PaymentId,p.PaymentDate
from Enrollments e
join StudentDetails s on e.StudentNo = s.StudentNo
join CourseDetails c on e.Ccode = c.Ccode
join FacultyDetails f on e.FacultyCode = f.FacultyCode
join Batch b on e.BatchCode = b.BatchCode
left join PaymentDetails p on s.StudentNo = p.StudentNo

