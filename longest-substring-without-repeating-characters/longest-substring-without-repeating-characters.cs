public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        HashSet<char> set=new HashSet<char>();
        
        int left=0;
        int ans=0;
        
        for(int right=0;right<s.Length;right++)
        {
            
            while(set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }
            
            if(!set.Contains(s[right]))
            {
                set.Add(s[right]);
            }
            ans=Math.Max(ans,right-left+1);
        }
        
        return ans;
        
    }
}