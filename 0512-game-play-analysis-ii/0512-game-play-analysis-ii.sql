# Write your MySQL query statement below
select a.player_id, a.device_id from Activity a
                            where (a.player_id, a.event_date) in (select player_id, Min(event_date) from Activity b
                                                                    group by b.player_id )