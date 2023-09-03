public class Solution {
    public int MissingNumber(int[] nums) {
        
        int sum=0;
        
        for(int i=0;i<nums.Length;i++)
        {
            sum=sum+nums[i];
        }
        
        int n=nums.Length;
        int expected=n*(n+1)/2;
        
        return expected-sum;
        
    }
}