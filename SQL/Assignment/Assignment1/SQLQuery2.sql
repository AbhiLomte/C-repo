Create database InfiniteDB
use InfiniteDB
Create table Clients
(
Client_ID int Primary Key,
Cname varchar(40) not null,
address varchar(30),
email varchar(40) unique,
phone int,
business varchar(20) not null
) 

Insert into Clients values
(1001,' ACME Utilities',' Noida',' contact@acmeutil.com',' 9567880032', 'Manufacturing'),
(1002, 'Trackon Consultants',' Mumbai', 'consult@trackon.com', '8734210090', 'Consultant'),
(1003,' MoneySaver Distributors', 'Kolkata', 'save@moneysaver.com', '7799886655', 'Reseller'),
(1004, 'Lawful Corp', 'Chennai',' justice@lawful.com', '9210342219', 'Professional')

select * from Clients;

Create table Departments
(
Deptno int Primary Key,
Dname varchar(20) not null,
Loc varchar(20)
)
Insert into Departments (Deptno,Dname,Loc) 
VALUES
(10,'Design','Pune'),
(20,'Development','Pune'),
(30 ,'Testing', 'Mumbai'),
(40 ,'Document','Mumbai')
Select * from Departments

Create table Employees 
(
Empno int Primary Key,
Ename varchar(20) Not Null,
Job varchar(40),
Salary float,
Deptno int,
CONSTRAINT FK_Deptno FOREIGN KEY (Deptno) REFERENCES Departments(Deptno)
);
Insert into Employees
VALUES
(7001 ,'Sandeep',' Analyst' ,25000 ,10),
(7002 ,'Rajesh' ,'Designer' ,30000 ,10),
(7003,' Madhav' ,'Developer', 40000 ,20),
(7004 ,'Manoj' ,'Developer' ,40000 ,20),
(7005, 'Abhay' ,'Designer' ,35000 ,10),
(7006 ,'Uma' ,'Tester' ,30000 ,30),
(7007, 'Gita' ,'Tech. Writer' ,30000 ,40),
(7008, 'Priya' ,'Tester' ,35000 ,30),
(7009, 'Nutan', 'Developer', 45000, 20),
(7010, 'Smita', 'Analyst', 20000, 10),
(7011, 'Anand', 'Project Mgr', 65000, 10)

select * from Employees

Create table Projects
(
Project_ID int,
Descr varchar(40),
Start_date datetime,
Planned_End_Date datetime,
Actual_End_Date datetime,
Budget int,
Client_id varchar(40)

)
Insert into Projects values
(401, 'Inventory', '01-Apr-11', '01-Oct-11', '31-Oct-11', 150000, '1001'),
(402,'Accounting' ,'01-Aug-11' ,'01-Jan-12',null, 500000, '1002'),
(403, 'Payroll',' 01-Oct-11', '31-Dec-11',null, 75000, '1003'),
(404, 'Contact Mgmt', '01-Nov-11',' 31-Dec-11',null, 50000, '1004')

select * from Projects




create table EmpProjectsTasks
(Project_ID int, Empno int, Start_Date datetime, End_Date datetime, Task varchar(40), Status varchar(30))
Insert into EmpProjectsTasks values
(401, 7001, '01-Apr-11', '20-Apr-11', 'System Analysis',' Completed'),
(401, 7002, '21-Apr-11', '30-May-11', 'System Design',' Completed'),
(401, 7003, '01-Jun-11', '15-Jul-11', 'Coding', 'Completed'),
(401, 7004, '18-Jul-11' ,'01-Sep-11', 'Coding', 'Completed'),
(401, 7006, '03-Sep-11', '15-Sep-11', 'Testing', 'Completed'),
(401, 7009, '18-Sep-11', '05-Oct-11', 'Code Change', 'Completed'),
(401, 7008, '06-Oct-11', '16-Oct-11', 'Testing', 'Completed'),
(401, 7007, '06-Oct-11', '22-Oct-11', 'Documentation', 'Completed'),
(401, 7011, '22-Oct-11', '31-Oct-11', 'Sign off', 'Completed'),
(402, 7010, '01-Aug-11', '20-Aug-11', 'System Analysis', 'Completed'),
(402, 7002, '22-Aug-11', '30-Sep-11', 'System Design', 'Completed'),
(402, 7004, '01-Oct-11' ,null,'Coding' ,'In Progress')
select * from EmpProjectsTasks