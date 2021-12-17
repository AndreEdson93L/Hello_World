-- query8
-- with union you can combine results from multiple queries
-- equal number of columns is important or you'll get an error
select first_name
from customers
union
select name
from shippers

-- query9
-- we can combine rows from multiple tables with unions
-- we can combine RECORDS from multiple queries (from the same or differents tables)

select
	order_id,
    order_date,
    'Active' as status
from orders
where order_date >= '2019-01-01'
union
select
	order_id,
    order_date,
    'Archived' as status
from orders
where order_date < '2019-01-01';

-- query10
select name as full_name
from shippers
union select first_name
from customers

-- query11 exercise
-- customer_id | first_name | points | type
-- points < 2000 bronze
-- points > 2000 and points < 3000 silver
-- points > 3000 gold
-- sort the result first_name

select
	customer_id as id,
    first_name as name,
    points,
    'Bronze' as type
from customers
where points < 2000
union
select
	customer_id as id,
    first_name as name,
    points,
    'Silver' as type
from customers
where points BETWEEN 2000 and 3000
union
select
	customer_id as id,
    first_name as name,
    points,
    'Gold' as type
from customers
where points > 3000
order by name