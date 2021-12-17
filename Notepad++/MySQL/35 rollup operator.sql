-- ROLL UP operator
-- query
SELECT
	client_id,
	SUM(invoice_total) AS total_sales
FROM invoices
GROUP BY client_id WITH ROLLUP

-- query
select
	state,
	city,
	sum(invoice_total) as total_sales
from invoices i 
join clients c using (client_id)
group by state, city with rollup

--exercise, my solution
select 
	pm.name as payment_method,
	sum(p.amount) as total	
from payments p
join payment_methods pm
	on p.payment_method = pm.payment_method_id
group by payment_method with rollup
order by payment_method desc


-- old queries
 use sql_invoicing;
 
 select * from invoices 
 order by client_id;
 
 select 
	client_id,
    sum(invoice_total) as total_sales,
    count(*) as number_of_invoices
from invoices
group by client_id
having total_sales > 500 and number_of_invoices > 5

--

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
   and state = 'VA'
   
--

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