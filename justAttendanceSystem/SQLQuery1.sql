create database Just_Attendance_System

create table class(
classID varchar(7) primary key,
className varchar(30) not null,
semester int not null)

create table student(
stdID varchar(7) primary key,
stdName varchar(50) not null,
gender varchar(8) not null,
classID varchar(7) foreign key references class(classID) on delete cascade,
email varchar(30) null unique,
telephone int unique not null,
password int  not null check( password = 6)
)

create table lecturer (
lecID varchar(7) primary key,
lecName varchar (50),
gender varchar(8) not null,
email varchar(30) unique,
telephone int unique not null,
password int  not null check( password = 6)
)

create table admin (
adminID varchar(7) primary key,
adminName varchar(50) not null,
password int  not null check( password = 6)
)

create table course(
courseID varchar(7) primary key,
courseName varchar(25) not null
)

create table examDepartment(
depID varchar(7) primary key,
campus int null,
password int  not null check( password = 6)
)

create table lecturerSubjects(
ID int identity(1,1) primary key,
lecID varchar(7) foreign key references lecturer(lecID),
classID varchar(7) foreign key references class(classID),
courseID varchar(7) foreign key references course(courseID)
)

create table attendance(
ID int identity(1,1) primary key,
stdID varchar(7) foreign key references student(stdID),
classID varchar(7) foreign key references class(classID),
courseID varchar(7) foreign key references course(courseID),
status varchar(7) default 'present',
date date )