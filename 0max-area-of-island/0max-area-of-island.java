class Solution {
    HashSet<String> visited=new HashSet<String>();
    
    public int maxAreaOfIsland(int[][] grid) {
        
        int ans=0;
        
        for(int i=0;i<grid.length;i++)
        {
            for(int j=0;j<grid[0].length;j++)
            {
                if(grid[i][j]==1 && !visited.contains(getHashCode(i,j)))
                {
                    
                   // visited.add(getHashCode(i,j));
                    ans=Math.max(ans,dfs(i,j,grid));
                }
            }
        }
        
        return ans;
    }
    
    public String getHashCode(int i,int j)
    {
        return i+","+j;
    }
    
    // public int area(int r, int c) {
    //     if (r < 0 || r >= grid.length || c < 0 || c >= grid[0].length ||
    //             seen[r][c] || grid[r][c] == 0)
    //         return 0;
    //     seen[r][c] = true;
    //     return (1 + area(r+1, c) + area(r-1, c)
    //               + area(r, c-1) + area(r, c+1));
    // }
    
    public int dfs(int i,int j,int[][] grid)
    {
        
        if(i<0 || i> grid.length-1 || j<0 || j>grid[i].length-1 || grid[i][j]==0 || visited.contains(getHashCode(i,j)))
            return 0;
        
        visited.add(getHashCode(i,j));
        
        return 1+dfs(i+1,j,grid)+dfs(i-1,j,grid)+dfs(i,j-1,grid)+dfs(i,j+1,grid);
            
        
    }
}