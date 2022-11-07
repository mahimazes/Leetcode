# Write your MySQL query statement below
 select A1.player_id,
        A1.event_date,
        sum(A1.games_played) over
        (partition by A1.player_id
         order by 
         A1.event_date)
        as games_played_so_far
 from Activity A1
