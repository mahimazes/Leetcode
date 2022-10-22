public class Solution {
    public int Search(int[] nums, int target) {
       
        return BinarySearch(nums,target,0,nums.Length-1);
    }
    
    public int BinarySearch(int[] nums,int target, int start, int end )
    {
        
        
        
        int mid=(start+end)/2;
        
        if(nums[mid]==target)
        {
            return mid;
        }
        
        if(start==end)
        {
            return -1;
        }
        
        if(nums[mid]<target)
        {
            return BinarySearch(nums,target,mid+1,end);
        }
        else if(nums[mid]>target)
        {
            return BinarySearch(nums,target,0,mid);
        }
        
        return -1;
    }
}