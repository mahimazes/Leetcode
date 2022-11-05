public class Solution {
    public bool BackspaceCompare(string s, string t) {
        if(StringStack(s)==StringStack(t))
            return true;
        else
            return false;
    }
    
    public string StringStack(string s)
    {
        StringBuilder result=new StringBuilder();
        int ind=1;
        for(int i=0;i<s.Length;i++)
        {
            if(s[i]=='#' && result.ToString()!="")
            {
                result.Remove(result.Length-1,1);
            }
            else if(s[i]!='#')
            {
                result.Append(s[i]);
            }
        }
        
        return result.ToString();
    }
}