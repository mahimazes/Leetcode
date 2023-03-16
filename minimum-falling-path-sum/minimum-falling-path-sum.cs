public class Solution {
    public int MinFallingPathSum(int[][] matrix) {
        
        int[,] dp=new int[matrix.Length,matrix[0].Length];
        
        for(int i=0;i<matrix[0].Length;i++)
        {
            dp[0,i]=matrix[0][i];
        }
        
        for(int i=1;i<matrix.Length;i++)
        {
            for(int j=0;j<matrix[0].Length;j++)
            {
                int ans=Int32.MaxValue;
                if(i>0)
                {
                    ans=Math.Min(ans,matrix[i][j]+dp[i-1,j]);
                }
                if(j<matrix[0].Length-1)
                {
                    ans=Math.Min(ans,matrix[i][j]+dp[i-1,j+1]);
                }
                if(i>0 && j>0)
                {
                    ans=Math.Min(ans,matrix[i][j]+dp[i-1,j-1]);
                }
                dp[i,j]=ans;
                
            }
        }
        
        int result=Int32.MaxValue;
        for(int i=0;i<matrix[0].Length;i++)
        {
            result=Math.Min(result,dp[matrix.Length-1,i]);
        }
        
        return result;
    }
}