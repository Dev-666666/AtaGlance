create table paintings
(painting_id int primary key,painting_name varchar(20),artist_id int,price int);
select * from paintings;
create table artist
(artist_id int primary key,artist_name varchar(20));
create table collectores
(coll_id int primary key,coll_name varchar(20));
create table sales
(s_id int ,sale_date Date ,painting_id int ,artist_id int,coll_id int,sprice decimal);
select * from paintings;
select * from sales;
select * from collectores;
select * from artist;