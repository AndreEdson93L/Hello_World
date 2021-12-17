-- query1
use sql_store;

select 
	c.customer_id,
    c.first_name,
    o.order_id
from customers c
inner join orders o
	on c.customer_id = o.customer_id
order by c.customer_id

-- query2
use sql_store;

select 
	c.customer_id,
    c.first_name,
    o.order_id
from customers c
left join orders o
	on c.customer_id = o.customer_id
order by c.customer_id

-- query3
use sql_store;

select 
	c.customer_id,
    c.first_name,
    o.order_id
from customers c
right join orders o
	on c.customer_id = o.customer_id
order by c.customer_id

-- query4
use sql_store;

select 
	c.customer_id,
    c.first_name,
    o.order_id
from orders o
right outer join customers c
	on c.customer_id = o.customer_id
order by c.customer_id

-- query5 exercise
select 
	p.product_id, 
    p.name, 
    oi.quantity
from products p 
left join order_items oi
	on p.product_id = oi.product_id
order by p.product_id;

--       join == inner join
-- right join == right outer join
--  left join == left outer join 