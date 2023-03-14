public class Solution {
    Dictionary<int,int> map=new Dictionary<int,int>();
    
    public int ClimbStairs(int n) {
        if(n==0 || n==1)
        {
            return 1;
        }
        
        if(map.ContainsKey(n))
        {
            return map[n];
        }
        else
        {
            map.Add(n,ClimbStairs(n-1)+ClimbStairs(n-2));
        }
        
        return map[n];
    }
}