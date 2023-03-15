public class Solution {
    public int CoinChange(int[] coins, int amount) {
        
        int[] dp=new int[amount+1];
        
        for(int i=0;i<=amount;i++)
        {
            dp[i]=amount+1;
        }
        
        dp[0]=0;
        
        for(int i=1;i<=amount;i++)
        {
            foreach(var coin in coins)
            {
                if(i<coin)
                    continue;
                dp[i]=Math.Min(dp[i],dp[i-coin]+1);
            }
        }
        
        if(dp[amount]==amount+1)
        {
            return -1;
        }
        else
            return dp[amount];
        
    }
}