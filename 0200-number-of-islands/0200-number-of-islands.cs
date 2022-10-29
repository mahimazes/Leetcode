

public class Solution {
    
     public struct point
    {
       public int x;
       public  int y;
    }
   
    
    public  HashSet<point> visited=new HashSet<point>();
    
    public void bfs(int r,int c, char[][] grid)
    {
        Queue<point> q=new Queue<point>();
        point p;
        p.x=r;
        p.y=c;
        
        if(!visited.Contains(p))
        {
           q.Enqueue(p);
           visited.Add(p);

        }
        point temp;   
        while(q.Count()!=0)
        {
            temp=q.Dequeue();
            
            List<Tuple<int,int>> directions=new List<Tuple<int,int>>();
            directions.Add(new Tuple<int,int>(0,1));
            directions.Add(new Tuple<int,int>(1,0));
            directions.Add(new Tuple<int,int>(0,-1));
            directions.Add(new Tuple<int,int>(-1,0));
            foreach(var dir in directions)
            {
                int row=temp.x+dir.Item1;
                int col=temp.y+dir.Item2;
                p.x=row;
                p.y=col;
                
                 if((row>=0 && row<grid.Length) &&
               (col>=0 && col<grid[0].Length) && grid[row][col]=='1' && !visited.Contains(p))
                {
                    q.Enqueue(p);
                    visited.Add(p);             
                }
                
            }
            
           
                   
        }
                 
    }
    
    public int NumIslands(char[][] grid) {
        
        int islands=0;
        point p;
        for(int i=0;i<grid.Length;i++)
        {
            for(int j=0;j<grid[0].Length;j++)
            {
                p.x=i;
                p.y=j;
                if(grid[i][j]=='1' && !visited.Contains(p))
                {
                   islands++;
                   bfs(i,j,grid);
                }   
            }
        }
        
        foreach(var vis in visited)
        {
            Console.WriteLine(vis.x+" "+vis.y+ " "+grid[vis.x][vis.y]);
        }
        
        return islands;
    }
}