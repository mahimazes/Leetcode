public class KthLargest {
    
    PriorityQueue<int,int> minheap=new PriorityQueue<int,int>();
    int Kval;
    
    public KthLargest(int k, int[] nums) {
        Kval=k;
        
        for(int i=0;i<nums.Length;i++)
        {
            minheap.Enqueue(nums[i],nums[i]);
            if(i>=Kval)
            {
                minheap.Dequeue();
            }
                
        }
    }
    
    public int Add(int val) {
        
        int kthlargestVal=0;
        minheap.Enqueue(val,val);
        if(minheap.Count>Kval)
        {
            minheap.Dequeue();
        }
        
        kthlargestVal=minheap.Peek();
        
        return kthlargestVal;
        
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */