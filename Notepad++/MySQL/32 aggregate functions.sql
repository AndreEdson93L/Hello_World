-- aggregate functions => max(), min(), avg(), sum(), count()
-- they only operate on nn (not null) values
-- order of execution => prima moltiplica invoice_total (ogni record) * 0.5, poi applica la funzione aggregata somma
select 
	max(invoice_total) as highest,
    min(invoice_total) as lowest,
    avg(invoice_total) as average,
    max(payment_date) as latest_date,
    sum(invoice_total ) as total,
    sum(invoice_total * 0.5) as half_total,
    count(invoice_total) as number_of_invoices,
    count(payment_date) as count_of_payments,
    count(*) as total_records,
    count(client_id) as 'n. of record with a client_id',
    count(distinct client_id) as 'n. of distinct client_id in the invoices table'
from invoices
where invoice_date > '2019-07-01'

-- query exercise
-- data_range   | total_sales | total_payments | what_we_expect |
-- f. half 2019 | 1539.07     | 662.69         | 876.38         |
-- s. half 2019 |             | 355.02         |
-- Total        |             | 1017.71        |
use sql_invoicing;
select
	'First_half' as data_range,
    sum(invoice_total) as total_sales,
    sum(payment_total) as total_payments,
    sum(invoice_total - payment_total) as what_we_expect
from invoices 
where invoice_date < '2019-07-01'
union
select
	'Second_half' as data_range,
    sum(invoice_total) as total_sales,
    sum(payment_total) as total_payments,
    sum(invoice_total - payment_total) as what_we_expect
from invoices 
where invoice_date >= '2019-07-01'
union
select
	'Total' as data_range,
    sum(invoice_total) as total_sales,
    sum(payment_total) as total_payments,
    sum(invoice_total - payment_total) as what_we_expect
from invoices 

-- query mosh solution
-- data_range   | total_sales | total_payments | what_we_expect |
-- f. half 2019 | 1539.07     | 662.69         | 876.38         |
-- s. half 2019 |             | 355.02         |
-- Total        |             | 1017.71        |
use sql_invoicing;
select
	'First_half' as data_range,
    sum(invoice_total) as total_sales,
    sum(payment_total) as total_payments,
    sum(invoice_total - payment_total) as what_we_expect
from invoices 
where invoice_date
	between '2019-01-01' and '2019-06-30'
union
select
	'Second_half' as data_range,
    sum(invoice_total) as total_sales,
    sum(payment_total) as total_payments,
    sum(invoice_total - payment_total) as what_we_expect
from invoices 
where invoice_date
	between'2019-07-01' and '2019-12-31'
union
select
	'Total' as data_range,
    sum(invoice_total) as total_sales,
    sum(payment_total) as total_payments,
    sum(invoice_total - payment_total) as what_we_expect
from invoices 
where invoice_date
	between '2019-01-01' and '2019-12-31'
