-- query1
use sql_store;

select 
	c.customer_id,
    c.first_name,
    o.order_id,
    sh.name AS shipper
from customers c
left join orders o
	on c.customer_id = o.customer_id
left join shippers sh
	on o.shipper_id = sh.shipper_id
order by c.customer_id

-- when using multiple join use 'left join' as best practice

-- query2 exercise
-- order_date | order_id | first_name | shipper | status
select 
	o.order_date,
    o.order_id,
    c.first_name,
    sh.name,
    os.name
from orders o 
left join customers c 
	on o.customer_id = c.customer_id
left join order_statuses os
	on o.status = os.order_status_id
left join shippers sh 
	on o.shipper_id = sh.shipper_id
order by os.name

-- query3 exercise mosh solution
-- order_date V| order_id V| first_name V| shipper | statusV

select 
	o.order_id,
    o.order_date,
    c.first_name as customer,
    sh.name as shipper,
    os.name as status
from orders o 
join customers c 
	on o.customer_id = c.customer_id
left join shippers sh
	on o.shipper_id = sh.shipper_id
join order_statuses os 
	on o.status = os.order_status_id
