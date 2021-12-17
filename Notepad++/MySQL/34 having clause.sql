-- query1
 use sql_invoicing;
 
 select * from invoices 
 order by client_id;
 
 select 
	client_id,
    sum(invoice_total) as total_sales,
    count(*) as number_of_invoices
from invoices
group by client_id
having total_sales > 500 and number_of_invoices > 5;

-- query2
-- Get the customers
-- located in Virginia
-- who have spent more than $100

select
	c.customer_id,
    c.first_name,
    c.last_name,
    sum(oi.quantity * oi.unit_price) as total_sales
from customers c
join orders o using (customer_id)
join order_items oi using (order_id)
where state = 'VA'
group by
	c.customer_id,
    c.first_name,
    c.last_name
having total_sales > 100;

-- query3
-- Get the customers
-- located in Virginia
-- who have spent more than $100
-- spezzo il problema in più parti

use sql_store;

-- all customers from Virginia
select *
from customers
where state = 'VA';

-- total sales
select
	order_id,
	sum(quantity * unit_price) as total_sales
from order_items
group by order_id;

select 
	c.customer_id as client,
    state,
    sum(oi.quantity * oi.unit_price) as total_sales
from customers c
join orders o
	using(customer_id)
join order_items oi
	using(order_id)
group by c.customer_id
having total_sales > 100
   and state = 'VA';