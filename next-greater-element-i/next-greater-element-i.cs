public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        
        Stack<int> stack=new Stack<int>();
        
        Dictionary<int,int> map=new Dictionary<int,int>();
        
        for(int i=0;i<nums2.Length;i++)
        {
            while(stack.Count>0 && nums2[i]>nums2[stack.Peek()])
            {
                //Console.WriteLine(nums2[i]+","+stack.Peek());
                int j=stack.Pop();
                map.Add(nums2[j],nums2[i]);
            }
            
            stack.Push(i);
        }
        
        int[] res=new int[nums1.Length];
        for(int i=0;i<nums1.Length;i++)
        {
            if(map.ContainsKey(nums1[i]))
            {
                res[i]=map[nums1[i]];
            }
            else
                res[i]=-1;
        }
        
        return res;
    }
}