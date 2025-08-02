create database HospitalManagementSystem
go

use HospitalManagementSystem
go

create table Doctor_master 
(
	doctor_id varchar(15) constraint pk_doctor_doctorId Primary Key,
	doctor_name varchar(30) not null,
	Dept varchar(30) not null
)

insert into Doctor_master(doctor_id,doctor_name,Dept)
values('D0001','Ram','ENT'),
('D0002','Rajan','ENT'),
('D0003','Smita','Eye'),
('D0004','Bhavan','Surgery'),
('D0005','Sheela','Surgery'),
('D0006','Nethra','Surgery')

create table ROOM_MASTER 
(
	room_no varchar(15) constraint pk_room_roomno Primary Key,
	room_type varchar(30) not null,
	room_status varchar(30) not null
)

insert into ROOM_MASTER(room_no,room_type,room_status)
values('R0001','AC','occupied'),
('R0002','Suite','vacant'),
('R0003','NonAC','vacant'),
('R0004','NonAC','occupied'),
('R0005','AC','vacant'),
('R0006','AC','occupied')

create table PATIENT_MASTER 
(
	pid varchar(15) constraint pk_patient_pid Primary Key,
	name varchar(30) not null,
	age numeric(15) not null,
	weight numeric(15) not null,
	Gender varchar(30) not null constraint chk_patient_gender 
		check(Gender IN('M','F')),
	Address varchar(50) not null,
	phoneno varchar(10) not null,
	Disease varchar(50) not null,
	 doctor_id varchar(15),
    FOREIGN KEY (doctor_id) REFERENCES Doctor_master(Doctor_id)
)

insert into PATIENT_MASTER(pid,name,age,weight,Gender,Address,phoneno,Disease,doctor_id)
values('P0001', 'Gita', 35, 65, 'F', 'Chennai', 9867145678, 'Eye Infection', 'D0003'),
('P0002', 'Ashish', 40, 70, 'M', 'Delhi', 9845675678, 'Asthma', 'D0003'),
('P0003', 'Radha', 25, 60, 'F', 'Chennai', 9867166678, 'Pain in heart', 'D0005'),
('P0004', 'Chandra', 28, 55, 'F', 'Bangalore', 9978675567, 'Asthma', 'D0001'),
('P0005', 'Goyal', 42, 65, 'M', 'Delhi', 8967533223, 'Pain in Stomach', 'D0004');


create table ROOM_ALLOCATION
(
	room_no varchar(15) FOREIGN KEY (room_no) REFERENCES ROOM_MASTER (room_no),
	pid varchar(15)     FOREIGN KEY (pid) REFERENCES PATIENT_MASTER (Pid),
	admission_date date not null,
	Release_date date not null
)

insert into ROOM_ALLOCATION(room_no,pid,admission_date,Release_date)
values ('R0001','P0001','15-Oct-16','26-oct-16'),
('R0002','P0002','15-nov-16','26-nov-16'),
('R0002','P0003','01-dec-16','30-dec-16'),
('R0004','P0001','01-jan-17','30-jan-17')

--Displaying the patients
select * from PATIENT_MASTER
go

select * from Doctor_master
go

select * from ROOM_ALLOCATION
go

select * from ROOM_MASTER
go

--Display the patients who were admitted in the month of january.
SELECT pid, name
FROM PATIENT_MASTER
WHERE pid IN (
    SELECT pid
    FROM ROOM_ALLOCATION
    WHERE MONTH(admission_date) = 1
);
--Display the female patient who is not suffering from asthma
select name from PATIENT_MASTER   where  Disease not in ( 'asthma') AND gender IN ('F')
--Count the number of male and female patients
SELECT Gender, COUNT(*) AS total
FROM PATIENT_MASTER WHERE Gender IN ('F', 'M') GROUP BY Gender;

--Display the patient_id,patient_name, doctor_id, doctor_name, room_no, room_type and admission_date.
select pid,name,doctor_id,doctor_name,room_no,room_type,admission_date from PATIENT_MASTER,Doctor_master,ROOM_ALLOCATION,ROOM_MASTER 
go
--Display the room_no which was never allocated to any patient.
select room_no from ROOM_MASTER where room_no not in (select room_no from ROOM_ALLOCATION) 
--Display the room_no, room_type which are allocated more than once
SELECT room_no,room_type
FROM ROOM_MASTER
WHERE room_no  IN (
    SELECT room_no
    FROM ROOM_ALLOCATION
    GROUP BY room_no
    HAVING COUNT(*) > 1
);


