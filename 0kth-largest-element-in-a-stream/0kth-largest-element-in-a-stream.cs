public class KthLargest {
    
    PriorityQueue<int,int> heap;
    int k_val;
    public KthLargest(int k, int[] nums) {
        
        heap=new PriorityQueue<int, int>();
        
        for(int i=0;i<nums.Length;i++)
        {
            heap.Enqueue(nums[i],nums[i]);
        }
        
        k_val=k;
        
        while(heap.Count>k)
        {
            heap.Dequeue();
        }
    }
    
    public int Add(int val) {
        
        heap.Enqueue(val,val);
        
        while(heap.Count>k_val)
        {
            heap.Dequeue();
        }
            
        return heap.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */