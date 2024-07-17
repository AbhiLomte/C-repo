use infiniteDB
--1
create table dayofweek ( id int PRIMARY KEY,
name VARCHAR(50), birthday DATE);
 
insert into dayofweek (id, name, birthday) values(1, 'Abhishek Lomte','1997-10-19');
 
select birthday from dayofweek where name = 'Abhishek Lomte';
--2
select DATEDIFF(DAY, '1997-10-19', '2024-07-17') as datedifference;
--3
SELECT *
FROM EMP
WHERE DATE_FORMAT(joined_date, '%Y-%m') = DATE_FORMAT(DATE_SUB(CURDATE(), INTERVAL 5 YEAR), '%Y-%m');
