/* Write your T-SQL query statement below */

/*select
    seat_id
from Cinema C1
where  C1.free=1 and 
      (((seat_id-1) in (select C2.seat_id 
                        from Cinema C2
                        where  C2.free=1)) or
       ((seat_id+1) in (select C2.seat_id 
                        from Cinema C2
                        where  C2.free=1)))
                        
                        */
                        
select distinct C1.seat_id
from Cinema C1 join Cinema C2 on abs(C1.seat_id-C2.seat_id)=1
where C1.free=1 and C2.free=1