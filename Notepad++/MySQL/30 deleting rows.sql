-- deleting rows 
-- query1
-- it deletes all the records in the table
delete from invoices

-- query2
delete from invoices
where invoice_id = 1

-- query3
use sql_invoicing;

delete from invoices
where invoice_id = 
	(select *
	from clients
	where name = 'Myworks');