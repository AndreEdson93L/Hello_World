-- query1
select *
from sql_store.customers
limit 3

-- query2
select *
from sql_store.customers
limit 6, 3
-- skip first six
-- display three records

-- query3
-- Get the top three loyal customers
select * 
from sql_store.customers
order by points desc
limit 3

-- limit clause comes always at the end
-- the ording of the queries matters
-- select/from/where/order by/limit