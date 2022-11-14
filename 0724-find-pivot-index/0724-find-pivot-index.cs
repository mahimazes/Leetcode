public class Solution {
    public int PivotIndex(int[] nums) {
        
        int sumfront=0,sumback=nums[nums.Length-1];
        int ind=-1;
        int front=0, back=nums.Length-1;
       /* while(front<back)
        {
            if(sumfront<sumback)
            {
                sumfront=sumfront+nums[front];
                front++;
            }
            else if(sumfront>sumback)
            {
                back--;
                sumback=sumback+nums[back];
            }
            else if(sumfront==sumback)
            {
                return front;
            }
        }
        */
        int sum = 0, leftsum = 0;
        for(int x=0;x<nums.Length;x++) 
        {
            sum += nums[x];
        }
        for (int i = 0; i < nums.Length; ++i) 
        {
            if (leftsum == sum - leftsum - nums[i]) 
                return i;
            leftsum += nums[i];
        }
        return -1;        

    }
    
}