use InfiniteDB
CREATE TABLE Employee_Details (
    Empno int PRIMARY KEY,
    EmpName varchar(50) NOT NULL,
    Empsal numeric(10,2) CHECK (Empsal >= 25000),
    Emptype char(1) CHECK (Emptype IN ('F', 'P'))
);
Insert into Employee_Details values
(1,'Mahesh',30000,'F'),
(2,'Ravi',20000,'F'),
(3,'Suresh',30000,'F'),
(4,'Ritesh',21000,'P')