create database AdvancedDB
use AdvancedDB

create table Employees(
Employeeld int primary key,
FirstName nvarchar(50),
LastName nvarchar(50),
Salary decimal)

insert into Employees values(1,'Viya','Gandhi',60000.30)
insert into Employees values(3,'Gopi','Mani',30000.40)

select * from Employees

create table Products(
ProductId int primary key,
ProductName nvarchar(50), 
Descriptions nvarchar(200), 
Price money,
ReleaseDate datetime)

insert into Products values(1001,'Face wash','A soap-free formulation that cleans impurities and helps clear pimples',190,'10/02/2023')
insert into Products values(1017,'Sunscreen','A photoprotective topical product for the skin that helps protect against sunburn and most importantly prevent skin cancer',560,'03/11/2023')

select * from Products

create table Orders(
OrderId int primary key,
OrderDate datetime,
Quantity smallint,
Discount float,
IsShipped bit)

insert into Orders values(104,'10/05/2023',2,0.10,1)
insert into Orders values(107,'08/02/2023',5,0.15,0)

select * from Orders