
public class Solution {
    public int MinStoneSum(int[] piles, int k) {
        
        //PriorityQueue<int,int> maxHeap=new PriorityQueue<int,int>(Comparer<int>.Create((x,y)=>y.CompareTo(x)));
        PriorityQueue<int,int> maxHeap=new PriorityQueue<int,int>();

        int sum=0;
        
        for(int i=0;i<piles.Length;i++)
        {
            maxHeap.Enqueue(piles[i],-1*piles[i]);
            sum=sum+piles[i];
        }
        
        int remaining=0;
        while(k>0)
        {
            int HeaviestStone=maxHeap.Dequeue();
             sum=sum-HeaviestStone/2;
            remaining=HeaviestStone-HeaviestStone/2;
            maxHeap.Enqueue(remaining,-1*remaining);
            k--;
        }
        
        return sum;
        
        
    }
}