public class Solution {
    public int[] FindBall(int[][] grid) {
        
        int[] result=new int[grid[0].Length];
        
        int currCol=0;
        for(int j=0;j<grid[0].Length;j++)
        {
            currCol=j;
            for(int i=0;i<grid.Length;i++)
            {
                int nextCol=currCol+grid[i][currCol];
                
                if(nextCol<0 || nextCol>grid[0].Length-1 || grid[i][currCol]!=grid[i][nextCol])
                {
                    result[j]=-1;
                    break;
                }
                result[j]=nextCol;
                currCol=nextCol;
            }
        }
        
        return result;
    }
}