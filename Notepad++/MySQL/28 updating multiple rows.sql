-- query1 
use sql_invoicing;
update invoices
set
	payment_total = invoice_total * 0.5,
    payment_date = due_date
where client_id = 3

-- query2
-- update every record in the table
use sql_invoicing;

update invoices
set
	payment_total = invoice_total * 0.5,
    payment_date = due_date
	
-- query3
use sql_invoicing;

update invoices
set
	payment_total = invoice_total * 0.5,
    payment_date = due_date
where client_id in (3, 4)

-- query4 exercise
-- Write s SQL statement to
-- give any customers born before 1990
-- 50 extra points
use sql_store;

update customers
set points = points + 50
where birth_date < '1990-01-01'