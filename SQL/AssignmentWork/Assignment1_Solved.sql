select * from employee;
--1.Write a query to display first_name and last_name 
--using alias ‘First Name’ & ‘Last Name’ from employee tale
select emp_fname as First_Name,emp_lname as Last_Name from employee;
--Write a query to get unique department ID from employee table
--select * from employee join department on department_id=dept_id;
select department_id from employee group by department_id;
--Write a query to get all employee details from employee table display in descending order
select * from employee order by emp_fname desc;
--Write a query to display employee details with salary, calculate the PF as 12 % of basic salary & display as separate column
select emp_id,emp_fname,emp_lname ,salary,((salary*12)/100) as Providend_Fund from employee;
--***--Write a query to get total salaries payable to all employees from employee table
--select count(*) from employee; 
select count(e.salary),department_id from employee e group by department_id;
--Write a query to get max and min salary of employee
select min(salary) as Minimum_salary ,max(salary) as Maximum_salary from employee;
--Write a query to get number of employees are working in company
select count(*) from employee;
--Write a query to get the number of unique designation in the company
select designation from employee group by designation;
--****--Write a query to display emp_name as ‘Name’ in upper case
select emp_fname as upper(name) from employee;
--Write a query to get first 10 records from the employee table
select TOP 10 * from employee;
