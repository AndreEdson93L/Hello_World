-- query1
select *
from store.customers
order by first_name desc

-- query2
SELECT * 
FROM sql_store.customers
ORDER BY first_name

-- query3
select *
from store.customers
order by state, first_name

-- query4
select *
from store.customers
order by state desc, first_name desc

-- query5
select first_name, last_name
from store.customers
order by birth_date

-- query6
select first_name, last_name, 1 AS 'single number'
from store.customers
order by 'single number', birth_date

-- query7
-- avoid this type of sorting datas
select *
from store.customers
order by 2, 3 

-- query8
-- order_id = 2
-- total price desc
select *, quantity * unit_price as 'total price'
from sql_store.order_items
where order_id = 2
order by 'total price' desc 

--query9
-- order_id = 2
-- total price desc
select *
from sql_store.order_items
where order_id = 2
order by quantity * unit_price desc