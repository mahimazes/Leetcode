class Solution {
    public int connectSticks(int[] sticks) {
        
        PriorityQueue<Integer> queue=new PriorityQueue<>();
        
        for(int i=0;i<sticks.length;i++)
        {
            queue.add(sticks[i]);    
        }
        
        int result=0;
        
        while(queue.size()!=1)
        {
            int newNum=queue.remove()+queue.remove();
            result= result+newNum;
            queue.add(newNum);
        }
        
        return result;
    }
}