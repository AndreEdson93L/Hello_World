-- query1
use sql_store;
-- it si complex written this way
select *
from orders o
join customers c 
	on o.customer_id = c.customer_id
join order_statuses os
	on o.status = os.order_status_id
	
-- query2
use sql_store;

select
	o.order_id,
    o.order_date,
    c.first_name,
    c.last_name,
    os.name AS status
from orders o
join customers c 
	on o.customer_id = c.customer_id
join order_statuses os
	on o.status = os.order_status_id
	
-- query3
-- exercise
-- display the client name and payment_method by merging three tables
use sql_invoicing;

select 
	c.name as 'client name', 
    pm.name as 'payment method',
    amount,
    date
from payments p 
join payment_methods pm
	on p.payment_method = pm.payment_method_id
join clients c 
	on p.client_id = c.client_id

-- query3
use sql_invoicing;

select 
	c.name as 'client name', 
    pm.name as 'payment method'
from payments p 
join payment_methods pm
	on p.payment_method = pm.payment_method_id
join clients c 
	on p.client_id = c.client_id
	
-- query4
use sql_invoicing;

select
	p.date,
    p.invoice_id,
    p.amount,
    c.name,
    pm.name as 'payment method'
from payments p 
join clients c 
	on p.client_id = c.client_id
join payment_methods pm
	on p.payment_method = pm.payment_method_id
	
-- query5
use sql_invoicing;

select *
from payments p 
join clients c 
	on p.client_id = c.client_id
join payment_methods pm
	on p.payment_method = pm.payment_method_id