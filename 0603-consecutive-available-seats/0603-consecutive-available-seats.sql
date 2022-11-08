/* Write your T-SQL query statement below */

select
    seat_id
from Cinema C1
where  C1.free=1 and 
      (((seat_id-1) in (select C2.seat_id 
                        from Cinema C2
                        where  C2.free=1)) or
       ((seat_id+1) in (select C2.seat_id 
                        from Cinema C2
                        where  C2.free=1)))