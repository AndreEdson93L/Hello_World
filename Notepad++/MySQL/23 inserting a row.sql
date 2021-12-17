-- query1
insert into customers
values (default, 'John', 'Smith', '1990-01-01', null, 'via Luigi P 27', 'MI', 'IT', default)

-- query2
use sql_store;
insert into customers (first_name, last_name, birth_date, address, city, state)
values('Mark', 'Berry', '1990-10-01', 'via Oxford 23', 'LN', 'UK')

-- query3
-- we can list them in any order
use sql_store;
insert into customers (last_name, first_name, birth_date, address, city, state)
values('Travolta', 'Jhon', '1990-10-01', 'via Oxford 23', 'LN', 'UK')