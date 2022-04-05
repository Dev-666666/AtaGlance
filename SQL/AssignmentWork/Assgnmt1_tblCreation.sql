create table employee 
(emp_id int identity(1,1) primary key,emp_fname varchar(20) not null,emp_lname varchar(20) not null,
department varchar(20) default 'Maintainance',designation varchar(20) not null,
salary decimal not null);
select * from employee;
alter table employee add department_id int ;
create table department(dept_id int primary key ,dept_name varchar(20));
select * from department;
select * from employee;
alter table employee add constraint fk foreign key (department_id) 
references department(dept_id);