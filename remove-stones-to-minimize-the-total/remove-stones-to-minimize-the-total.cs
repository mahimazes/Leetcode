public class Solution {
    public int MinStoneSum(int[] piles, int k) {
        PriorityQueue<int,int> heap=new PriorityQueue<int,int>(Comparer<int>.Create((x,y)=>(y.CompareTo(x))));
        
        //add to heap
        for(int i=0;i<piles.Length;i++)
        {
            heap.Enqueue(piles[i],piles[i]);
        }
        
        //while k is zero
        while(k>0)
        {
            //remove top element and add element-floor(element/2)
            int top=heap.Dequeue();
            int new_num=top-(int)Math.Floor(1.0*top/2);
            heap.Enqueue(new_num,new_num);
            k--;
        }
        
        int sum=0;
        
        while(heap.Count>0)
        {
            sum=sum+heap.Dequeue();
        }
        
        return sum;
    }
}