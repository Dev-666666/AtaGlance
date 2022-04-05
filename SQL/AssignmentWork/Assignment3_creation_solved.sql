create table product(p_id int ,p_name varchar(20),quantity int ,price decimal);
select * from product;
--Use the MIN function to select the record with the smallest value of the Price column.
select min(price) from product;
--Use an SQL function to select the record with the highest value of the Price column.
select max(price) from product;
--Use the correct function to return the number of records that have the Price value set to 20
select count(*) from product where price=2000;
--Use an SQL function to calculate the average price of all products.
select AVG(price) from product group by p_name;
--Use an SQL function to calculate the sum of all the Price column values in the Products table

--Use the BETWEEN operator to select all the records where the value of the Price column is between 10 and 20
select * from product where price BETWEEN 2000 and 5000;
--Use the BETWEEN operator to select all the records where the value of the Price column is NOT between 10 and 20.
select * from product where price NOT BETWEEN 2000 and 5000;
--***--Use the BETWEEN operator to select all the records where the value of the ProductName column is alphabetically between 'Geitost' and 'Pavlova'.
select * from product where p_name BETWEEN mouse and USB order by p_name;
--Write the correct SQL statement to create a new database called testDB.
create database testDB;
--Write the correct SQL statement to delete a database named testDB
delete database testDB;
--Add a column of type DATE called Birthday in Persons table
create table persona(p_name varchar(20));
alter table persona add Birthdate Date ;
select * from persona;
--Delete the column Birthday from the Persons table
delete Birthdate from persona;