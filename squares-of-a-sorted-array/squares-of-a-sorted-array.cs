public class Solution {
    public int[] SortedSquares(int[] nums) {
        
        int[] result=new int[nums.Length];
        
        int first=0;
        int last=nums.Length-1;
        int ind=last;
        
        while(first<=last && ind>=0)
        {
            if(Math.Abs(nums[first])<Math.Abs(nums[last]))
            {
               result[ind]=(int)Math.Pow(nums[last],2);
                last--;
            }
            else
            {
                result[ind]=(int)Math.Pow(nums[first],2);
                first++;
            }
            ind--;
        }
        
        return result;
    }
}