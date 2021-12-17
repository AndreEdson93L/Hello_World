-- query1
use sql_invoicing;

update invoices
set
	payment_total = invoice_total * 0.5,
    payment_date = due_date
where client_id = 
			-- the subquery will be executed first
			(select client_id
            from clients
            where name = 'Myworks');
			
-- query2
use sql_invoicing;

update invoices
set
	payment_total = invoice_total * 0.5,
    payment_date = due_date
where client_id in
            -- if the query/subquery return multiple records you must use IN and not = 
            -- the subquery will be executed first
			(select client_id
            from clients
            where state in ('CA', 'NY'));
			
-- query3
use sql_invoicing;

update invoices
set
	payment_total = invoice_total * 0.5,
    payment_date = due_date;
-- prima controlla quali modifiche andrai a fare scrivendo una query/subquery a parte.. dopo di che (vai alla query successive per esempio)    
select *
from invoices
where payment_date is null;

-- query4 
-- verificata, eseguiamo la nostra query
use sql_invoicing;

update invoices
set
	payment_total = invoice_total * 0.5,
    payment_date = due_date
where payment_date is null;

-- query5 exercise
-- scrivi un commento per i customers che hanno più di 3000 punti comments = 'gold customer'
use sql_store;

update orders
set comments = 'gold customer'
where customer_id  in
	(select customer_id
	from customers 
	join orders 
		using(customer_id)
	where points >= 3000 and comments is null);
	
-- query6 exercise
use sql_store;

update orders
set comments = 'Gold customer'
where customer_id in
		(select customer_id
        from customers
        where points > 3000)