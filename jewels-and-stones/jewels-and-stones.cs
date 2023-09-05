public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        
        HashSet<char> set=new HashSet<char>();
        
        for(int i=0;i<jewels.Length;i++)
        {
            if(!set.Contains(jewels[i]))
            {
                set.Add(jewels[i]);
            }
        }
        
        int ans=0;
        
        for(int i=0;i<stones.Length;i++)
        {
            if(set.Contains(stones[i]))
            {
                ans++;
            }
        }
        
        return ans;
        
    }
}