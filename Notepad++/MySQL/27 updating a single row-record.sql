-- query1
update invoices
set payment_total = 10, payment_date = '2019-03-01'
where invoice_id = 1

-- query2
update invoices
set payment_total = default, payment_date = default
where invoice_id = 1

-- query3
update invoices
set 
	payment_total = invoice_total * 0.5, 
    payment_date = due_date
where invoice_id = 3

-- query4
update invoices
set 
	payment_total = invoice_total * 0.5, 
    payment_date = due_date
where invoice_id = 3