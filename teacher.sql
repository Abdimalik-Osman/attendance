create database Just_Attendance_System
drop table teachers
create table teachers(
teach_ID int identity(1,1) primary key,
teach_userName varchar(55) unique,
teach_fullName varchar(55),
teach_pass varchar(88),
teach_phone varchar(88) unique,
teach_DOB varchar(55),
teach_gender varchar(77),
teach_email varchar(88) unique,
teach_Address varchar(66),
teach_role varchar(78));

insert into teachers values('T1122','mohamed khalaf','667788','6166889','2/3/1990','male',
'khalaf21@gmail.com','warta nabada', 'teacher')
select *From teachers