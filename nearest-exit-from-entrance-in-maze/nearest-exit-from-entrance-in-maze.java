class Maze
{
    int x;
    int y;
    int steps;
    
    public Maze(int r,int c, int s)
    {
        x=r;
        y=c;
        steps=s;
    }
}    

class Solution {
    
    public boolean isExit(int x,int y, char[][] maze)
    {
        if(x==0 || x==maze.length-1 || y==0 || y== maze[0].length-1)
            return true;
        
        return false;
    }
    
    public boolean isValid(int x,int y, char[][] maze)
    {
        if((x<0 || x> maze.length-1 || y<0 || y> maze[0].length-1))
            return false;
        
        if(maze[x][y]=='+')
            return false;
        
        return true;
    }
    
    public String getHashCode(int x,int y)
    {
        return x+","+y;
    }
    
    public int nearestExit(char[][] maze, int[] entrance) {
        
        Queue<Maze> queue=new LinkedList<>();
        HashSet<String> seen=new HashSet<>();
        int[][] directions=new int[][]{{0,1},{1,0},{0,-1},{-1,0}};
        
        
        queue.add(new Maze(entrance[0],entrance[1],0));
        
        seen.add(getHashCode(entrance[0],entrance[1]));
        
        while(queue.size()>0)
        {
             Maze temp=queue.remove();
               
            for(int[] dir : directions)
            {
               int currx=temp.x+dir[0];
               int curry=temp.y+dir[1];
               //int currsteps=testeps+1;
                
              
               if(isValid(currx,curry,maze) && !seen.contains(getHashCode(currx,curry)))
               {
                    if(isExit(currx,curry,maze) && !(currx==entrance[0] && curry==entrance[1]))
                    {
                        return temp.steps+1;
                    }
                
                   
                   seen.add(getHashCode(currx,curry));
                   queue.add(new Maze(currx,curry,temp.steps+1));
               }
            }
            
        }
        
        return -1;
        
    }
}