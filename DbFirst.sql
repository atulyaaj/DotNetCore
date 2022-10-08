create database ValtechDb;

use ValtechDb;

create table employees(
EmployeeId int primary key,
EmployeeName varchar(50)
);

create table projects(
ProjectId int primary key,
ProjectName varchar(100),
EmployeeId int foreign key references employees(EmployeeId));

 select * from employees;
 select * from projects;