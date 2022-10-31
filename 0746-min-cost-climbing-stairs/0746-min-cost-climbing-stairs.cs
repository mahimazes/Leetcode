public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        
        int n=cost.Length;
        int[] dp=new int[cost.Length+1];
       /* int i=n;
        int ind=0;
        while(i>1)
        {
            if(cost[i-1]<cost[i-2])
            {
                dp[ind]=dp[ind]+cost[i-1];
                i=i-1;
                
            }
            else
            {
                dp[ind]=dp[ind]+cost[i-2];
                i=i-2;
            }
            ind++;
        }
        
        int sum=0;
        foreach(var d in dp)
        {
            sum=sum+d;
        }*/
        
        for(int i=2;i<dp.Length;i++)
        {
            int onestep=dp[i-1]+cost[i-1];
            int twostep=dp[i-2]+cost[i-2];
            dp[i]=Math.Min(onestep,twostep);
        }
        
        return dp[dp.Length-1];
    }
}