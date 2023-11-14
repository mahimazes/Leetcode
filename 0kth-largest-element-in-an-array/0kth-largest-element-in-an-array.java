class Solution {
    public int findKthLargest(int[] nums, int k) {
        
        PriorityQueue<Integer> queue=new PriorityQueue<>();
        
        for(int num : nums)
        {
            queue.add(num);
            while(queue.size()>k)
            {
                queue.remove();
            }
        }
        
        return queue.peek();
        
    }
}