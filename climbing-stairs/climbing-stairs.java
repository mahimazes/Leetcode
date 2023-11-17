class Solution {
    public int climbStairs(int n) {
        
        int[] dp=new int[n];
        
        if(n==1 || n==2)
        {
            return n;
        }
            
        
        dp[0]=1; //1 step
        dp[1]=2; //2nd step
        
        for(int i=2;i<n;i++)
        {
            dp[i]=dp[i-2]+dp[i-1];
        }
        
        return dp[n-1];
    }
}