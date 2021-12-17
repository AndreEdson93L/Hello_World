-- query1
-- the result is set by default by the attribute specified in the group by clause
select 
	client_id,
	sum(invoice_total) as total_sales
from invoices
group by client_id

-- query2
select 
	client_id,
	sum(invoice_total) as total_sales
from invoices
group by client_id
order by total_sales desc

-- query3
-- select/from/where/group by/order by
select 
	client_id,
	sum(invoice_total) as total_sales
from invoices
where invoice_date >= '2019-07-01'
group by client_id
order by total_sales desc

-- query4
select 
	client_id,
	sum(invoice_total) as total_sales
from invoices
join clients using (client_id)
where invoice_date >= '2019-07-01'
group by client_id
order by total_sales desc

-- query5
select 
	*
from invoices
join clients using (client_id)
where invoice_date >= '2019-07-01'

-- query6
select 
	state,
    city,
	sum(invoice_total) as total_sales
from invoices
join clients using (client_id)
group by state, city

-- query7
select 
	state,
    city,
	sum(invoice_total) as total_sales
from invoices
join clients using (client_id)
group by state

-- query8
select 
	state,
    city,
	sum(invoice_total) as total_sales
from invoices
join clients using (client_id)
group by city

-- query9
-- date        | payment_method name | total_payments |
-- 2019-01-08  | Credit Card         | 74.55          |
-- 2019-01-08  | Credit Card         | 32.77          |
-- 2019-01-08  | Cash		         | 10.00          |
-- 2019-01-11  | Credit Card         | 0.03           |
-- 2019-01-15  | Credit Card         | 148.41         |
-- 2019-01-26  | Credit Card         | 87.44          |
-- 2019-02-12  | Credit Card         | 8.18           |

select 
	p.date,
    pm.name as payment_method_name,
    sum(p.amount) as total
from payments p
join payment_methods pm
	on p.payment_method = pm.payment_method_id
group by p.date, pm.name
order by p.date

-- query10
select
	date,
    pm.name as pament_method,
    sum(amount) as total_payments
from payments p join payment_methods pm
	on p.payment_method = pm.payment_method_id
group by date, payment_method
order by date