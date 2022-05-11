create database justAttendanceSystem
create table semester(
semID int primary key ,
semesName varchar(8) not null
)
Create table faculty(
ID int primary key,
facultyName varchar(20) not null
)
create table class(
classID varchar(3) primary key,
className varchar(10) not null,
semID int foreign key references semester(semID))

create table student(
stdID varchar(7) primary key,
stdName varchar(50) not null,
gender varchar(8) not null,
classID varchar(3) foreign key references class(classID) on delete cascade,
email varchar(30) null unique,
telephone int unique not null,
password int  not null check(len([password]) between 6 and 6 )
)

create table lecturer (
lecID varchar(7) primary key,
lecName varchar (50),
gender varchar(8) not null,
email varchar(30) unique,
telephone int unique not null,
password int  not null check(len([password]) between 6 and 6 )
)

create table admin (
adminID varchar(7) primary key,
adminName varchar(50) not null,
password int  not null check(len([password]) between 6 and 6 )
)


create table course(
courseID varchar(4) primary key,
courseName varchar(25) not null,
hours int not null check (hours >= 48 or hours <= 80),
semID int foreign key references semester(semID),
facID int foreign key references faculty(ID)
)

create table examDepartment(
depID varchar(7) primary key,
campus int null,
password int  not null check(len([password]) between 6 and 6 )
)

create table lecturerSubjects(
ID int identity(1,1) primary key,
lecID varchar(7) foreign key references lecturer(lecID),
classID varchar(3) foreign key references class(classID),
courseID varchar(4) foreign key references course(courseID)
)

create table attendance(
ID int identity(1,1) primary key,
stdID varchar(7) foreign key references student(stdID),
classID varchar(3) foreign key references class(classID),
courseID varchar(4) foreign key references course(courseID),
status varchar(7) default 'present',
date date default  getdate() )

select * from attendance
select * from student

select distinct(course.courseID)  from semester inner join course on semester.semID=course.semID
inner join class on semester.semID =class.semID
where course.semID='5' and course.facID=1
 
select * from attendance 
alter table class add ID int foreign key references faculty(ID);
update  class set ID = 2 where classID like 'e%'
delete attendance


select student.stdID, student.stdName, class.className, course.courseName, attendance.status, attendance.date From attendance inner join student on attendance.stdID = student.stdID inner join class on attendance.classID = class.classID inner join course on attendance.courseID = course.courseID
where student.stdID = 'C119006'

select distinct(count(status)) as total_Present, student.stdID, student.stdName, class.className, course.courseName, attendance.status
 From attendance inner join student on attendance.stdID = student.stdID inner join class on attendance.classID = class.classID inner join course on attendance.courseID = course.courseID
where student.stdID = 'C119006' group by student.stdID, student.stdName, class.className, course.courseName, attendance.status;
select *FRom class

select student.stdID,student.stdName, class.className,course.courseName,attendance.date, attendance.status from attendance inner join class on attendance.classID = class.classID inner join course on attendance.courseID=course.courseID inner join student on attendance.stdID = student.stdID  where class.classID='C01' and course.courseName= (select courseName where course.courseID='SA06' and student.stdID='C119002')

select stdID from  student where classID='C01'