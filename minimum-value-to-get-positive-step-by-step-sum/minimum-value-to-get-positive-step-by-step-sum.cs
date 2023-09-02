public class Solution {
    public int MinStartValue(int[] nums) {
        
        int[] prefix=new int[nums.Length];
        
        prefix[0]=nums[0];
        int min=prefix[0];

        for(int i=1;i<nums.Length;i++)
        {
            prefix[i]=prefix[i-1]+nums[i];
            min=Math.Min(min,prefix[i]);
        }
        
        if(min<0)
        {
            return Math.Abs(min)+1;
        }
        return 1;
    }
}