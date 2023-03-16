public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        
        int[,] dp=new int[obstacleGrid.Length,obstacleGrid[0].Length];
        
        if(obstacleGrid[0][0]==1)
            return 0;
        
        dp[0,0]=1;
        for(int i=0;i<obstacleGrid.Length;i++)
        {
            for(int j=0;j<obstacleGrid[0].Length;j++)
            {
                if(i==0 && j==0)
                    continue;
                
                if(obstacleGrid[i][j]==1)
                    continue;
                
                int ans=0;
                
                if(i>0)
                    ans=ans+dp[i-1,j];
                if(j>0)
                    ans=ans+dp[i,j-1];
                
                dp[i,j]=ans;
            }
        }
        
        return dp[obstacleGrid.Length-1,obstacleGrid[0].Length-1];
    }
}