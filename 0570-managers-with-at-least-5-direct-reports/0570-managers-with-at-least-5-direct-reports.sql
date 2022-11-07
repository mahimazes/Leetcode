# Write your MySQL query statement below

select
E2.name
      from Employee E1
      join Employee E2 on E1.ManagerId=E2.Id
      group by E1.ManagerId
      having count(E1.ManagerId)>=5

/*
select 
    name
from Employee E1
join (select
     ManagerId
      from Employee 
      group by ManagerId
      having count(ManagerId)>=5
     ) as E2
     on E1.id=E2.ManagerId
*/
-- Employee E2 on E1.id=E2.managerId

-- having count(E1.managerId)>=5
