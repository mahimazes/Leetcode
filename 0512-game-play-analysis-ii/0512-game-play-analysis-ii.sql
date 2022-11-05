/* Write your T-SQL query statement below */
select a.player_id, a.device_id from Activity a
                            where event_date=(select Min(event_date) from Activity b
                                                                    where b.player_id=a.player_id )