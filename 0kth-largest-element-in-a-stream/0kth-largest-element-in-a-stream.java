class KthLargest {
    
    PriorityQueue<Integer> queue= new PriorityQueue<Integer>();
    int kval;
    
    public KthLargest(int k, int[] nums) {
        kval=k;
        int i=0;
        
        if(nums.length==0)
        {
            return;
        }
        
        while(i<nums.length)
        {
            while(queue.size()>kval)
            {
                queue.remove();    
            }
            
            queue.add(nums[i]);
            i++;
        }
    }
    
    public int add(int val) {
        
        queue.add(val);
        
        while(queue.size()>kval)
        {
            queue.remove();
        }
        
        return queue.peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.add(val);
 */