select * from customer;
--Write a statement that will select the City column from the Customers table
select city from customer;
--Select all the different values from the Country column in the Customers table.
select city as Different_cities from customer group by city;
--Select all records where the City column has the value "London
select * from customer where country='landon';
--Use the NOT keyword to select all records where City is NOT "Berlin".
select * from customer where country NOT like 'Berlin';
--Select all records where the CustomerID column has the value 23.
select * from customer where cust_id=5;
--Select all records where the City column has the value 'Berlin' and the
--PostalCode column has the value 121110.
select * from customer where city='Mumbai' and postal_code=101;
--Select all records where the City column has the value 'Berlin' or 'London'.
select * from customer where country in('Berlin','landon');
--Select all records from the Customers table, sort the result alphabetically 
--by the column City.-
select * from customer order by city ;
--Select all records from the Customers table, sort the result 
--reversed alphabetically by the column City.
select * from customer order by city desc ;
--Select all records from the Customers table, sort the result alphabetically,
--first by the column Country, then, by the column City
--***-- 
select * from customer order by country ,city;
--Select all records from the Customers where the PostalCode column is empty.
select * from customer where postal_code is NULL;
--Select all records from the Customers where the PostalCode column is NOT empty.
select * from customer where postal_code is NOT NULL;
--Set the value of the City columns to 'Oslo', but only the ones
--where the Country column has the value "Norway".
update customer set city='oslo' where country='Norway';
--Delete all the records from the Customers table where the Country value is 'Norway'.
delete from customer where country='Norway';
--Select all records where the value of the City column starts with the letter "a".
select * from customer where city like 'a%';
--Select all records where the value of the City column ends with the letter "a".
select * from customer where city like '%a';
--Select all records where the value of the City column contains the letter "a".
select * from customer where city like '%a%';
--Select all records where the value of the City column starts with letter "a" and
--ends with the letter "b".
select * from customer where city like 'a%b';
--Select all records where the value of the City column does NOT start with the letter "a".
select * from customer where city <> 'a%';
--Select all records where the second letter of the City is an "a".
select * from customer where city like '.a%';
--Select all records where the first letter of the City is an "a" or a "c" or an "s".
select * from customer where city in('a%','c%','s%');
--Select all records where the first letter of the City starts with anything from 
--an "a" to an "f".
select * from customer where city like 'a-f%';
--Select all records where the first letter of the City is NOT an "a" or a "c" or an "f".
select * from customer where city in('a%','c%','s%');
--Use the IN operator to select all the records where the Country is either
--"Norway" or "France".
select * from customer where city in('Norway','Berlin');
--Use the IN operator to select all the records where the Country is either
--not "Norway" or "France".
select * from customer where city NOT in('Norway','Berlin');
--When displaying the Customers table, make an ALIAS of the PostalCode column, 
--***---the column should be called Pno instead.
select *,  postal_code as pno from customer;
--When displaying the Customers table, refer to the table as Consumers instead of Customers.
--List the number of customers in each country.
select count(*),country from customer group by country;
--List the number of customers in each country, ordered by the country with the most customers first.
select count(*) as no,country from customer group by country order by no desc;