create database Day08
use Day08
drop table Emps
create table Emps
(Id int primary key, 
Fname nvarchar(50) not null,
Lname nvarchar(50) not null,
Designation nvarchar(50),
Salary float,
DOJ date)

insert into Emps values (1,'Preethi','Shankar','Developer',63000.20,'10/21/2021')
insert into Emps values (2,'Sakthi','Priya','Hr',53000.20,'09/10/2020')
insert into Emps values (3,'Priya','Shankar','Tester',23000.20,'04/11/2022')
insert into Emps values (12,'Keerthi','Vasan','Developer',36000.20,'11/01/2023')

select * from Emps

create proc usp_eEmployee
@id int,
@fn nvarchar(50),
@ln nvarchar(50),
@desg nvarchar(50),
@sal float,
@doj datetime
as
insert into Emps(Id,Fname,Lname,Salary,Designation,DOJ) values
(@id,@fn,@ln,@sal,@desg,@doj)

exec usp_eEmployee 11,'subu','Raj','Developer',85000.50,'01/23/2022'

select * from Emps

-----------------------------------------------------
create proc usp_dEmps
@id int 
as delete from Emps where Id= @id

exec usp_dEmps 12

select * from Emps
----------------------------------------
create proc usp_searchEmp
@id int
as
select * from Emps where Id=@id
------------------------------------------

exec usp_searchEmp 2