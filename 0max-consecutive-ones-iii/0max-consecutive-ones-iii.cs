public class Solution {
    public int LongestOnes(int[] nums, int k) {
        
        int zeroCount=0;
        int left=0;
        int ans=0;
        
        for(int right=0;right<nums.Length;right++)
        {
            if(nums[right]==0)
            {
                zeroCount++;
            }
            
            while(zeroCount>k)
            {
                if(nums[left]==0)
                {
                    zeroCount=zeroCount-1;
                }
                left++;
            }
            
            ans=Math.Max(ans,right-left+1);    
        }
        
        return ans;
        
    }
}