-- query1
-- MAX()
-- MIN()
-- AVG()
-- SUM()
-- COUNT()

-- query2
use sql_invoicing;

select max(invoice_total) as highest,
	   min(invoice_total) as lowest,
       avg(invoice_total) as average,
       sum(invoice_total) as total,
       count(invoice_total) as number_of_invoices,
       count(payment_date) as count_of_payments,
       count(*) as total_records
from invoices

-- query3
use sql_invoicing;

select max(invoice_total) as highest,
	   min(invoice_total) as lowest,
       avg(invoice_total) as average,
       sum(invoice_total * 1.1) as total,
       count(*) as total_records
from invoices
where invoice_date > '2019-07-01'

-- query4
use sql_invoicing;

select max(invoice_total) as highest,
	   min(invoice_total) as lowest,
       avg(invoice_total) as average,
       sum(invoice_total * 1.1) as total,
       count(*) as total_records
from invoices
where invoice_date > '2019-07-01'

-- query5
use sql_invoicing;

select max(invoice_total) as highest,
	   min(invoice_total) as lowest,
       avg(invoice_total) as average,
       sum(invoice_total * 1.1) as total,
       count(distinct client_id) as total_records
from invoices
where invoice_date > '2019-07-01'

-- query6
use sql_invoicing;

select max(invoice_total) as highest,
	   min(invoice_total) as lowest,
       avg(invoice_total) as average,
       sum(invoice_total * 1.1) as total,
       count(client_id) as total_records
from invoices
where invoice_date > '2019-07-01'

-- query7

-- data/range             |total_sales | total_payments | what_we_expect |
-- firs half of 2019      |1539.07     | 662.69         | 876.38         |
-- second half of 2019    |1051.53     | 355.02         | 696.51         |
-- Total                  |2590.60     | 1017.71        | 1572.89        |

select 
	'First half of 2019' as data_range,
    sum(invoice_total) as total_sales,
    sum(payment_total) as total_payments,
    sum(invoice_total - payment_total) as what_we_expect
from invoices
where invoice_date 
	between '2019-01-01' and '2019-06-30'
union
select 
	'Second half of 2019' as data_range,
    sum(invoice_total) as total_sales,
    sum(payment_total) as total_payments,
    sum(invoice_total - payment_total) as what_we_expect
from invoices
where invoice_date 
	between '2019-07-01' and '2019-12-31'
union
select 
	'Total' as data_range,
    sum(invoice_total) as total_sales,
    sum(payment_total) as total_payments,
    sum(invoice_total - payment_total) as what_we_expect
from invoices
where invoice_date 
	between '2019-01-01' and '2019-12-31'
