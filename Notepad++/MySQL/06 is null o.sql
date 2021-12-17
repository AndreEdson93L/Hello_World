-- query1
select *
from store.customers
where phone is null

-- query2
select *
from store.customers
where phone is not null

-- query3
-- Get the orders that are not shipped
select *
from store.orders
where shipped_date is null