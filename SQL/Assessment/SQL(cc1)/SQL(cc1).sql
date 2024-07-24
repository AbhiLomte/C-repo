use infiniteDB
--1
drop table if exists birthday
create table birthday
(
NAME varchar(30),
DOB date
)
insert into birthday values
('Abhishek','1997-10-19')
select dayofweek(DOB) from birthday
 
insert into dayofweek (id, name, birthday) values(1, 'Abhishek Lomte','1997-10-19');
 
select birthday from dayofweek where name = 'Abhishek Lomte';
--2
select DATEDIFF(DAY, '1997-10-19', '2024-07-17') as datedifference;
--3
create table Emp1
(
empno int,
ename varchar(30),
job varchar(30),
sal float,
Hiredate date
) 
Insert into Employee values
(1,'mahesh','testing',4000,'2020-03-01'),
(2,'Suresh','testing',4000,'2020-02-01'),
(3,'Krishna','testing',4000,'2020-01-01'),
(5,'Ravi teja','testing',4000,'2019-12-01'),
(4,'Abhishek','developer',5000,'2019-12-02')

SELECT *
FROM Employee
WHERE DATE_ADD(Hiredate, INTERVAL 5 YEAR) <= CURDATE()
  AND YEAR(Hiredate) = YEAR(CURDATE())
  AND MONTH(Hiredate) = MONTH(CURDATE());




--4
BEGIN TRANSACTION;

-- a. Insert 3 rows
INSERT INTO Employee (empno, ename,job, sal,HIREDATE ) VALUES
    (1, 'Mahesh','testing', 50000.00, '2020-01-15'),
    (2, 'Suresh','testing', 60000.00, '2019-05-20'),
    (3, 'Krishna','testing', 55000.00, '2021-03-10');

-- b. Update the second row sal with 15% increment
UPDATE Employee
SET sal = sal * 1.15
WHERE empno = 2;

-- c. Delete first row
DELETE FROM Employee
WHERE empno = 1;

-- Commit the transaction
COMMIT;
--5
DELIMITER //

CREATE FUNCTION CalculateBonus(deptno INT, sal DECIMAL(10, 2)) RETURNS DECIMAL(10, 2)
BEGIN
    DECLARE bonus DECIMAL(10, 2);

    IF deptno = 10 THEN
        SET bonus = sal * 0.15;  -- 15% bonus for Deptno 10
    ELSEIF deptno = 20 THEN
        SET bonus = sal * 0.20;  -- 20% bonus for Deptno 20
    ELSE
        SET bonus = sal * 0.05;  -- 5% bonus for other departments
    END IF;

    RETURN bonus;
END //

DELIMITER ;
//created table
-- Example usage of the function to calculate bonus for employees
SELECT empno, ename, sal, deptno, CalculateBonus(deptno, sal) AS bonus
FROM Employee;


