public class Solution {
    public string MakeGood(string s) {
        
        Stack<char> stack=new Stack<char>();
        
        for(int i=0;i<s.Length;i++)
        {
            if(stack.Count > 0 && SameCharDiffCase(stack.Peek(),s[i]))
            {
                stack.Pop();
            }
            else
                stack.Push(s[i]);
        }
        
        
        string ans="";
        while(stack.Count>0)
        {
            ans=stack.Pop()+ans;
        }
        
        return ans;
    }
    
    public bool SameCharDiffCase(char a,char b)
    {
        return ((Char.IsUpper(a) && Char.IsLower(b)) || (Char.IsLower(a) && Char.IsUpper(b))) && Char.ToLower(a)==Char.ToLower(b); 
    }
}