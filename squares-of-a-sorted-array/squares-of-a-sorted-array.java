class Solution {
    public int[] sortedSquares(int[] nums) {
        
        
        int[] result=new int[nums.length];
        
        int left=0;
        int right=nums.length-1;
        
        int k=nums.length-1;
        while(left<=right && k>=0)
        {
            if(Math.abs(nums[left]) > Math.abs(nums[right]))
            {
                result[k]=nums[left]*nums[left];
                left++;
            }
            else
            {
                result[k]=nums[right]*nums[right];
                right--;
            }
            k--;
            
        }
        
        return result;
        
    }
}