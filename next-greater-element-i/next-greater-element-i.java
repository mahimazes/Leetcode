class Solution {
    public int[] nextGreaterElement(int[] nums1, int[] nums2) {
        
        Stack<Integer> monoDecStack=new Stack<Integer>();
        
        //int[] reff=new int[nums2.length];
        
        HashMap<Integer,Integer> map=new HashMap<>();
        
       // Arrays.fill(reff,-1);
        
        for(int i=0;i<nums2.length;i++)
        {
            while(monoDecStack.size()>0 && nums2[monoDecStack.peek()]<nums2[i])
            {
                //reff[monoDecStack.pop()]=nums2[i];
                map.put(nums2[monoDecStack.pop()],nums2[i]);
            }
            
            monoDecStack.push(i);
        }
        
        
        
        for(int i=0;i<nums1.length;i++)
        {
            if(!map.containsKey(nums1[i]))
            {
                nums1[i]=-1;
            }
            else
                nums1[i]=map.get(nums1[i]);
        }
        
        return nums1;
    }
}