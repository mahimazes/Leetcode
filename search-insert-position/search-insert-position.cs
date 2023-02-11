public class Solution {
    public int SearchInsert(int[] nums, int target) {
        
        int left=0;
        int right=nums.Length-1;
        
         while(left<=right)
        {
             int mid=left+(right-left)/2;
             Console.WriteLine(mid);
        
             if(nums[mid]==target)
             {
                 return mid;
             }
            else if(nums[mid]>target)
            {
                right=mid-1;
            }
            else if(nums[mid]<=target)
            {
                left=mid+1;
            }
        }
        
        return left;
        
        
    }
    
   
}