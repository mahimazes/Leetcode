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
       /* int result=0;
        int temp=0;
        
        List<int> temp_k=new List<int>();
        
       int count=0;
        while(count<k_val && heap.Count>0)
        {
            if(heap.TryDequeue(out temp,out result))
            {
                count++;
                //Console.WriteLine(k_val+","+result+","+count);
                temp_k.Add(result);
            }
            
        }
        
        foreach(var i in temp_k)
        {
            heap.Enqueue(i,i);
        }
        */
        
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