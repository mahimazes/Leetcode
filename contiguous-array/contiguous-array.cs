public class Solution {
    public int FindMaxLength(int[] nums) {
        
        Dictionary<int,int> map=new Dictionary<int,int>();
        
        int sum=0;
        int maxLength=0;
        map.Add(0,-1);
        
        for(int i=0;i<nums.Length;i++)
        {
            // if(nums[i]==0)
            // {
            //     sum=sum-1;
            // }
            // else
            // {
            //     sum=sum+nums[i];
            // }
            
            sum=sum + (nums[i]==1 ? 1 : -1);
            
            if(map.ContainsKey(sum))
            {
                maxLength=Math.Max(maxLength,i-map[sum]);
            }
            else
            {
                map.Add(sum,i);
            }
        }
        
        return maxLength;
        
    }
}