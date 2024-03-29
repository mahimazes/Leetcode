# Write your MySQL query statement below
 select A1.player_id,
        A1.event_date,
        sum(A2.games_played)
        as games_played_so_far
 from Activity A1
 join Activity A2 on A1.player_id=A2.player_id and A1.event_date>=A2.event_date
 group by A1.player_id,
        A1.event_date
