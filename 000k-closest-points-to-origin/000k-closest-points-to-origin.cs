public class Solution {
    public double CalculateDistance(int x1,int y1, int x2,int y2)
    {
        double result;
        
        result=Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
        
        return result;
    }
    
    public int[][] KClosest(int[][] points, int k) {
        
        PriorityQueue<int,double> heap=new PriorityQueue<int,double>(Comparer<double>.Create((x,y)=>(y.CompareTo(x))));
        
        for(int i=0;i<points.Length;i++)
        {
            heap.Enqueue(i,CalculateDistance(points[i][0],points[i][1],0,0));
            if(heap.Count>k)
                heap.Dequeue();
        }
        
        int[][] result=new int[k][];
        int j=0;
        while(heap.Count>0)
        {
            if(heap.TryDequeue(out int index,out double distance))
            {
                result[j]=new int[2];
                result[j][0]=points[index][0];
                result[j][1]=points[index][1];
                j++;
            }
            
        }
        
        return result;
    }
}