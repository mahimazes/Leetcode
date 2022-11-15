public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        
        int bottom=matrix.Length;
        int right=matrix[0].Length;
        int top=0;
        int left=0;
        //int i=0,j=0;
        List<int> result=new List<int>();
        //first row
        
        while(left<right && bottom>top)
        {
            for(int i=left;i<right;i++)
            {
                result.Add(matrix[top][i]);
            }
            top=top+1;
            
            for(int i=top;i<bottom;i++)
            {
                result.Add(matrix[i][right-1]);
            }
            right=right-1;
            
            if(left>=right || top>=bottom)
               break;
            
            for(int i=right-1;i>=left;i--)
            {
                result.Add(matrix[bottom-1][i]);
            }
            bottom=bottom-1;
            
            for(int i=bottom-1;i>=top;i--)
            {
                result.Add(matrix[i][left]);
            }
            left=left+1;
        }
        
        return result;
    }
}