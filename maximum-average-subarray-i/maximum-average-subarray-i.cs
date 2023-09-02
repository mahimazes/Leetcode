public class Solution {
    
    public double FindMaxAverage(int[] nums, int k) {
        
        double sum=0;
        double avg=0;
        for(int i=0;i<k;i++)
        {
            sum=sum+nums[i];
        }
        avg=sum/k;
    
        for(int i=k;i<nums.Length;i++)
        {
            sum=sum+nums[i]-nums[i-k];
            avg=Math.Max(avg,sum/k);
        }
        
        return avg;    
    }
}