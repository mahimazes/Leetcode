public class Solution {
    public int NumPairsDivisibleBy60(int[] time) {
        
        int[] seen=new int[60];
        int count=0;
        
        foreach(var item in time)
        {
            count=count+seen[(60-(item%60))%60];
            seen[item%60]++;    
        }
        
        return count;
    }
}