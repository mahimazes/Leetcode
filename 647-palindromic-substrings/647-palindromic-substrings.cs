public class Solution {
    public int CountSubstrings(string s) {
        
        int ans=0;
        
        for(int i=0;i<s.Length;i++)
        {
            ans=ans+countPalindromeAroundTheCentre(s,i,i);
                
            ans=ans+countPalindromeAroundTheCentre(s,i,i+1);
        }
        
        return ans;
    }
    
    public int countPalindromeAroundTheCentre(string s, int lo, int hi)
    {
        int ans=0;
        while(lo>=0 && hi< s.Length){
            
            if(s[lo]==s[hi])
            {
                lo--;
                hi++;
                ans++;
            }
            else if(s[lo]!=s[hi])
                break;
            
        }
        
        return ans;
    }
}