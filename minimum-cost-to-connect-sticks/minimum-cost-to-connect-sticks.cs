public class Solution {
    public int ConnectSticks(int[] sticks) {
        
        //Minheap
        
        PriorityQueue<int,int> minheap=new PriorityQueue<int,int>();
        
        for(int i=0;i<sticks.Length;i++)
        {
            minheap.Enqueue(sticks[i],sticks[i]);
        }
        
        int result=0;
        
        while(minheap.Count!=1)
        {
            int stick1=minheap.Dequeue();
            int stick2=minheap.Dequeue();
            int cost= stick1+stick2;
            result=result+cost;
            
            minheap.Enqueue(cost,cost);
        }
        
        return result;
        
    }
}