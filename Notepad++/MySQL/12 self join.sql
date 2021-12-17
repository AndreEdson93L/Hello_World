-- query1
use sql_hr;

select *
from employees e
join employees as manager
	on e.reports_to = manager.employee_id

-- query2
use sql_hr;
-- m as manager
select 
	e.employee_id,
    e.first_name as employee,
    m.first_name as manager
from employees e
join employees m
	on e.reports_to = m.employee_id
	