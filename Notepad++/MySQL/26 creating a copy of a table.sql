-- creating a copy of a table
-- query1
-- crea una copia quasi perfetta.. in questo caso però non riporta le pk (cioè order_id etc.. no saranno più pk (primary key) con l' ai (autoincrement)
-- quì il select statement è una subquery
-- una subquery è uno select statement che è parte di una altro select statement

create table orders_archived as
select * from orders

-- query2
-- possiamo usare la select come una subquery per copiare i dati di una tabella in un' altra
insert into orders_archived
select *
from orders
where order_date < '2019-01-01'

-- query3
-- copy of invoices into invoices_archived
-- switch client id with client name (join with the client table)
-- usare il tutto come una subquery in a create table statement
-- copiare solo invoices che hanno un pagamento (payment_date

create table invoices_archived as
select 
	invoice_id,
    number,
    c.name as client,
    invoice_total,
    payment_total,
    invoice_date,
    due_date,
    payment_date
from invoices as i
join clients as c
	using(client_id)
where payment_date is not null
order by invoice_id

-- query4
create table invoices_archived as 
select 
	i.invoice_id,
    i.number,
    c.name as client,
    i.invoice_total,
    i.payment_total,
    i.invoice_date,
    i.due_date,
    i.payment_date
from invoices as i
join clients as c
	using(client_id)
where payment_date is not null
order by invoice_id