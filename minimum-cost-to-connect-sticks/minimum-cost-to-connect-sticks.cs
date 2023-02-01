public class Solution {
    public int ConnectSticks(int[] sticks) {
        
        PriorityQueue<int,int> heap=new PriorityQueue<int,int>();
        
        for(int i=0;i<sticks.Length;i++)
        {
            heap.Enqueue(sticks[i],sticks[i]);
        }
        
        int sum=0;
        while(heap.Count>1)
        {
            int a=heap.Dequeue();
            int b=heap.Dequeue();
            
            sum=sum+a+b;
            
            heap.Enqueue(a+b,a+b);
        }
        
        return sum;
        
    }
}