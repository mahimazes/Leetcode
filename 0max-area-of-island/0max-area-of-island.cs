public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        
        HashSet<String> visited=new HashSet<String>();
        
        int ans=0;
        
        for(int i=0;i<grid.Length;i++)
        {
            for(int j=0;j<grid[0].Length;j++)
            {
                if(grid[i][j]==1 && !visited.Contains(StringKey(i,j)))
                {
                    ans=Math.Max(ans,dfs(grid,visited,i,j));
                }
            }
        }
        
        return ans;
    }
    
    String StringKey(int i,int j)
    {
        return i+","+j;
    }
    
    bool isValid(int[][] grid, int i, int j)
    {
        return (i>=0 && i< grid.Length && j>=0 && j<grid[0].Length && grid[i][j]==1 );
    }
    
    int dfs(int[][] grid, HashSet<String> visited, int i, int j)
    {
        if( !isValid(grid,i,j) || visited.Contains(StringKey(i,j)))
        {
            return 0;
        }
        
        visited.Add(StringKey(i,j));
        
        return 1+ dfs(grid, visited, i+1, j) +dfs(grid, visited, i-1, j)+dfs(grid, visited, i, j+1)+dfs(grid, visited, i, j-1);
    }
    
}