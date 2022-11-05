public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int,int> LookUp=new Dictionary<int,int>();
        int[] result=new int[2];
        
        
        for(int i=0;i<nums.Length;i++)
        {
            
            LookUp.Add(i,nums[i]);
            
        }
        
        for(int i=0;i<nums.Length;i++)
        {
            if(LookUp.ContainsValue(target-nums[i]) && LookUp.FirstOrDefault(x => x.Value == target-nums[i]).Key!=i)
            {
                result[0]=i;
                result[1]=LookUp.FirstOrDefault(x => x.Value == target-nums[i]).Key;
                return result;
            }
        }
        
        return result;
    }
}