 -- subquery
 select *
 from products
 where unit_price > (
	select unit_price
	from products
	where product_id = 3
)

-- In sql_hr database:
--    Find employees whose earn more than average
-- 	  My solution

use sql_hr;

select 
	employee_id as id, 
    first_name as name, 
    salary 
from employees 
where salary > (
	select avg(salary)
    from employees
)
order by salary