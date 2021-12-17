-- query1

use sql_store;

-- explicit join syntax
select *
from orders o 
join customers c 
	on o.customer_id = c.customer_id
	
	
-- query 2

-- implicit join syntax
select *
from orders o, customers c
where o.customer_id = c.customer_id
