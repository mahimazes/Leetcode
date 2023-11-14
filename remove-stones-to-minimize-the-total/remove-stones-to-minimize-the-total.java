class Solution {
    public int minStoneSum(int[] piles, int k) {
        
        PriorityQueue<Integer> queue=new PriorityQueue<>(Comparator.reverseOrder());
        
        for(int i=0;i<piles.length;i++)
        {
            queue.add(piles[i]);
        }
        
        int ans=0;
        while(k>0)
        {
            int num=queue.remove();
            
            queue.add(num-num/2);
            
            k--;
        }
        
        while(queue.size()>0)
        {
            ans=ans+queue.remove();
        }
        
        return ans;
        
    }
}