public class Solution {
    public bool IsSubsequence(string s, string t) {
        
        int sindex=0,tindex=0;
        
        if(s.Length==0)
            return true;
        
        
        while(sindex<s.Length && tindex<t.Length)
        {
            if(s[sindex]==t[tindex])
            {
                sindex++;
                
                if(sindex==s.Length)
                {
                    return true;
                }
            }
            tindex++;
        }
        
        return false;
    }
}