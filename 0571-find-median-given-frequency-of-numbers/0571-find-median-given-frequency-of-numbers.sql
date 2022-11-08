/* Write your T-SQL query statement below */

with temp as(
select num,
    frequency,
sum(frequency) over (order by num asc) as lower_lim,
sum(frequency) over (order by num desc) as upper_lim
from Numbers
)

select avg(num*1.0) as Median
from temp
where abs(upper_lim-lower_lim)<=frequency