public class Solution {
    public int MinStartValue(int[] nums) {
        
        int[] prefix=new int[nums.Length];
        
        prefix[0]=nums[0];
        int min=prefix[0];
        for(int i=1;i<nums.Length;i++)
        {
            prefix[i]=prefix[i-1]+nums[i];
            if(prefix[i]<min)
                min=prefix[i];
        }
        
        int ans=0;
        if(min<=0)
            ans=Math.Abs(min)+1;
        else if(min-1>=1)
            ans=1;
        else
            ans=min;
        
        return ans;
        
        
    }
}