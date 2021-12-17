-- query1
-- cross to combine every record in the first table with every record in the second table 
-- so you won't have any condition
select * 
from customers c
cross join products p

-- query2
-- a real world example 
-- colors (red blue green)
-- size (small medium large)
select
	c.first_name as customer,
    p.name as product
from customers c
cross join products p
order by c.first_name

-- query3
-- implicit cross join syntax
select
	c.first_name as customer,
    p.name as product
from customers c, products p
order by c.first_name

-- query4 exercise1
-- Do a cross join between shippers and products
-- using the implicit syntax
-- and then using the explicit syntax
select
	p.product_id,
    p.name,
    sh.name
from shippers sh, products p
order by p.product_id

-- query5 exercise2
select
	p.product_id,
    p.name,
    sh.name
from shippers sh
cross join products p
order by p.product_id

-- query5 exercise3
select *
from products p
cross join shippers sh
order by p.

-- query6
select
	sh.name as shipper,
    p.name as product
from shippers sh, products p
order by sh.name

-- query7
select
	sh.name as shipper,
    p.name as product
from shippers sh
cross join products p
order by sh.name