/* Write your T-SQL query statement below */
select 
 d.dept_name as dept_name, 
count(s.student_id) as student_number
from Department d left join student s
on s.dept_id=d.dept_id
group by d.dept_name
order by student_number desc, d.dept_name

/*
select
    d.dept_name 'dept_name'
,   count(s.dept_id) 'student_number'
from Department d
left join Student s on s.dept_id = d.dept_id
group by d.dept_name
order by student_number desc, dept_name;*/