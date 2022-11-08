/* Write your T-SQL query statement below */


select top 1 ord.customer_number 
from (
    select
    customer_number,count(customer_number) ct
    from Orders
    group by customer_number
) as ord
order by ord.ct desc
