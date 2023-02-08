public class Solution {
    public int square(int x)
    {
        return x*x;
    }
    public int[] SortedSquares(int[] nums) {
        
        int left=0;
        int right=nums.Length-1;
        int[] result=new int[nums.Length];
        
        for(int i=nums.Length-1;i>=0;i--)
        {
            if(Math.Abs(nums[right])>Math.Abs(nums[left]))
            {
                result[i]=(int)Math.Pow(nums[right],2);
                right--;
            }
            else
            {
                result[i]=(int)Math.Pow(nums[left],2);
                left++;
            }
        }
        
        return result;
    }
}