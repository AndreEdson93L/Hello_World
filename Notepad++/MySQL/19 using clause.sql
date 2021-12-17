-- query1
use sql_store;

select
	o.order_id,
    c.first_name,
    sh.name as shipper
from orders o 
join customers c
	-- on o.customer_id = c.customer_id
    using(customer_id)
left join shippers sh
	using(shipper_id)
	
-- query2
select *
from order_items oi
join order_item_notes oin
	on oi.order_id = oin.order_id and
	   oi.product_id = oin.product_id
	   
-- query3
-- we simplify with the using keyword
select *
from order_items oi
join order_item_notes oin
	using (order_id, product_id)
	
-- query4 exercise
-- date | client | amount | name
use sql_invoicing;

select 
	p.date,
	c.name as client,
    p.amount,
    pm.name
from payments p
join clients c 
	using(client_id)
join payment_methods pm 
	on p.payment_method = pm.payment_method_id 
-- on si a clause
