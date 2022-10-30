public class Solution {
    public int ClimbStairs(int n) {
        
        int[] memo=new int[n+1];
       return ClimbStairs(0,n,memo);
       
        
    }
    
    public int ClimbStairs(int i,int n,int[] memo)
    {
        if(i==n)
        {
            return 1;
        }
        
        if(i>n)
        {
            return 0;
        }
        
        if(memo[i]>0)
        {
            return memo[i];
        }
        
        memo[i]=ClimbStairs(i+1,n,memo)+ ClimbStairs(i+2,n,memo);
        
        return memo[i];
    } 
}