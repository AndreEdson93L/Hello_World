-- inner joins

-- query1
select * 
from sql_store.orders as o
inner join sql_store.customers as c 
	on o.customer_id = c.customer_id
-- it displays in order: orders table, customers table

-- query2
select order_id, first_name, last_name
from sql_store.orders as o
inner join sql_store.customers as c 
	on o.customer_id = c.customer_id
	
-- query3
select order_id, o.customer_id, first_name, last_name
from sql_store.orders as o
inner join sql_store.customers as c 
	on o.customer_id = c.customer_id
	
-- query4
select order_id, o.customer_id, first_name, last_name
from sql_store.orders o
inner join sql_store.customers c 
	on o.customer_id = c.customer_id
	
-- query5
-- how inner join as join works..
select *
from sql_store.order_items oi
join sql_store.products p 
	on oi.product_id = p.product_id
	
-- query5
-- order_id, product_id, product_name, quantity, unit_price
select order_id, oi.product_id, quantity, oi.unit_price
from sql_store.order_items oi 
inner join sql_store.products p 
	on oi.product_id = p.product_id
    order by product_id, order_id
	
-- query6
select order_id, oi.product_id, quantity, oi.unit_price
from sql_store.order_items oi
join sql_store.products p 
	on oi.product_id = p.product_id
