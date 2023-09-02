public class Solution {
    public int[] GetAverages(int[] nums, int k) {
        
        Int64[] prefix=new Int64[nums.Length];
        prefix[0]=nums[0];
        
        for(int i=1;i<nums.Length;i++)
        {
               prefix[i]=prefix[i-1]+nums[i]; 
        }
        
        int[] result=new int[nums.Length];
       /* 
        for(int i=0;i<nums.Length;i++)
        {
            if((i-k) < 0 || (i+k) > (nums.Length-1))
            {
                result[i]=-1;
            }
            else if((i-k)==0)
            {
                result[i]=(int)prefix[i+k]/(2*k+1);
            }
            else
            {
                result[i]=(int)(prefix[i+k]-prefix[i-(k+1)])/(2*k+1);
            }
        }
        */
        for (int i = 0; i < nums.Length; i++) 
        {
            int left = i - k;
            int right = i + k;
        
             if (left < 0 || right >= nums.Length) 
             {
                result[i] = -1;
             } 
             else 
             {
                result[i] = (int)((prefix[right] - (left > 0 ? prefix[left - 1] : 0)) / (2 * k + 1));
             }
        }

        return result;
        
    }
}