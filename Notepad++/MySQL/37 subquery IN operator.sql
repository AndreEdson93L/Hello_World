-- subquery, in operator 

use sql_store;

select *
from products
where product_id not in (
	select distinct product_id
	from order_items
)

-- Find clients without invoices
-- My solution

use sql_invoicing;

select client_id
from clients
where client_id not in (
	select client_id
    from invoices
)

-- His solution

use sql_invoicing

select *
from clients
where client_id not in (
	select distinct client_id
	from invoices
)
