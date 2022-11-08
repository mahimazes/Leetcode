/* Write your T-SQL query statement below */

/*
select top 1 ord.customer_number 
from (
    select
    customer_number,count(customer_number) ct
    from Orders
    group by customer_number
) as ord
order by ord.ct desc
*/

select top 1 customer_number
from Orders
group by customer_number
order by count(*) desc
