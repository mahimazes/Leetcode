public class MovingAverage {

    Queue<int> queue;
    int s;
    int sum=0;
    public MovingAverage(int size) {
     
        queue=new Queue<int>();
        s=size;
    }
    
    public double Next(int val) {
        
        double result=0;
        queue.Enqueue(val);
        
        sum=sum+val;
        
        while(queue.Count>s)
        {
            sum=sum-queue.Dequeue();
           // queue.Enqueue(val);
                
        }
        
        result=sum * 1.0 / queue.Count;
        
        return result;
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */