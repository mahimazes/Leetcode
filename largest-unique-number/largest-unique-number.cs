public class Solution {
    public int LargestUniqueNumber(int[] nums) {
        
        Dictionary<int,int> map=new Dictionary<int,int>();
        
        for(int i=0;i<nums.Length;i++)
        {
            if(map.ContainsKey(nums[i]))
            {
                map[nums[i]]++;
            }
            else
            {
                map.Add(nums[i],1);
            }
        }
        
        int max=-1;
        
        foreach(var pair in map)
        {
            if(pair.Value==1)
            {
                max=Math.Max(max,pair.Key);
            }
        }
        
        return max;
    }
}