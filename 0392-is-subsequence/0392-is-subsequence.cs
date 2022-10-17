public class Solution {
    public bool IsSubsequence(string s, string t) {
        
        int sindex=0,tindex=0;
        
        while(sindex<s.Length && tindex<t.Length)
        {
            if(s[sindex]==t[tindex])
            {
                sindex++;
            }
            tindex++;
        }
        
        if(sindex==s.Length)
        {
            return true;
        }
        return false;
    }
}