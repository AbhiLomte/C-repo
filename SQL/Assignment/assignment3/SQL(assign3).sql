use InfiniteDB 
drop table if exists EMP1
drop table if exists dept1
Create table EMP1
(
empno int,
ename varchar(30),
job varchar(30),
mgrid int,
hiredate datetime,
sal float,
comm varchar(30),
deptno int 
)
Insert into EMP1(empno, ename, job, mgrid, hiredate, sal, comm, deptno)  values
(7369  ,'SMITH','CLERK',	      		7902   	,	'17-DEC-80' ,    	 800	,'',         20),
(7499 ,  'ALLEN',    'SALESMAN',    		 7698,   	'20-FEB-81',    	 1600  ,'   300 ',   30),
(7521,  'WARD',	'SALESMAN',        	7698 ,   	'22-FEB-81',  	 1250,    '500',   30),
(7566 , 'JONES',   'MANAGER',       	7839 ,  	 	'02-APR-81' ,  	 2975, '' ,          20),
(7654,   ' MARTIN',  'SALESMAN',     		 7698,   	 '28-SEP-81',  	 1250 ,'1400',    30),
(7698,	'BLAKE',    'MANAGER', 	   	 7839, 	    	 '01-MAY-81',       2850,'',            30),
(7782 , 	'CLARK',    'MANAGER',      		 7839  ,  	'09-JUN-81',   	 2450 ,'',           10),
(7788,  	'SCOTT',     'ANALYST',      		 7566   ,	'19-APR-87 ',     3000,'',             20),
(7839 ,   'KING',      'PRESIDENT',            	null		,'17-NOV-81',      5000,''  ,           10),
(7844 ,   'TURNER',   'SALESMAN',      	7698,    	'08-SEP-81',    	 1500,     ' 0'   ,  30),
(7876 ,   'ADAMS',    'CLERK' ,        	7788  ,  	'23-MAY-87',        1100,  '',          20),
(7900 ,   'JAMES' ,    'CLERK',        		 7698 ,  	 '03-DEC-81',  	 950, '',            30),
(7902,    'FORD',     'ANALYST',     		  7566,   	 '03-DEC-81',   	 3000, '',           20),
(7934 ,  'MILLER',   'CLERK',        		 7782 ,   	'23-JAN-82',	 1300,'',            10)
select * from EMP1
create table Dept1
(
deptno int,
dname varchar(30),
loc varchar(30)
)
Insert into Dept1 values
(10 ,'ACCOUNTING','    NEW YORK' ),
(20 , 'RESEARCH', '     DALLAS' ),
(30,    'SALES',        ' CHICAGO' ),
(40 ,   'OPERATIONS ',  ' BOSTON' )
select * from Dept1
--1
select * from EMP1 where job ='MANAGER'
--2
select ename ,sal from EMP1 where sal >1000
--3
select ename, sal from EMP1 where ename != 'JAMES'
--4
select * from EMP1 where ename like  'S%'
--5
select ename from EMP1 where ename like '%A%'
--6
select ename from EMP1 where ename like '__L%'
--7
select sal/12 from EMP1 where ename = 'JONES'
--8
select ename,sal*12 as yearlysal from EMP1
--9
select avg(sal*12) as avg_annualsal from EMP1
--10
select ename, job,sal,deptno from EMP1 where job ='SALESMAN' and deptno=30
--11
SELECT DISTINCT dname
FROM dept1
where deptno = (select deptno from EMP1)
--12
SELECT ename AS Employee, sal AS "Monthly Salary"
FROM EMP1
WHERE sal > 1500
  AND (deptno = 10 OR deptno = 30);
  --13
  select ename, job,sal from EMP1 where job IN('MANAGER','ANALYST') and sal not In (1000,3000,5000)
  --14
  SELECT ename AS Employee, sal AS Salary, comm AS Commission
FROM EMP1
WHERE comm > sal * 1.1;
--15
SELECT ename AS Employee
FROM EMP1
WHERE (ename LIKE '%L%L%' OR ename LIKE '%L%L%')
  AND (deptno = 30 OR mgrid = 7782);
  --16
  SELECT 
    ename,
    DATEDIFF(day,CURDATE(), hiredate) / 365 AS experience_in_years
FROM 
    Emp
WHERE 
    DATEDIFF(day,CURDATE(), hiredate) / 365 BETWEEN 30 AND 39;
--17
SELECT 
    d.dname AS Department,
    e.ename AS Employee
FROM 
    Departments d
LEFT JOIN 
    Employees e ON d.deptno = e.Deptno
ORDER BY 
    d.dname ASC,
    e.ename DESC;



--18 
Select ename as employee, hiredate 
months_between('2024-07-18',hiredate)
from EMP1
where ename ='MILLER'
select dname,deptno from Dept1
