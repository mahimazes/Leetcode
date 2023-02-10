public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        
        Stack<int> stack=new Stack<int>();
        
        Dictionary<int,int> hMap=new Dictionary<int,int>();
        
        for(int i=0;i<nums2.Length;i++)
        {
            int count=0;
            while(stack.Count!=0 && nums2[i]>stack.Peek())
            {   
                hMap.Add(stack.Pop(),nums2[i]);
            }
            stack.Push(nums2[i]);
            
        }
        
        int[] result=new int[nums1.Length];
        
        for(int i=0;i<nums1.Length;i++)
        {
            if(hMap.ContainsKey(nums1[i]))
                result[i]=hMap[nums1[i]];
            else
                result[i]=-1;
        }
        
        return result;
        
    }
}