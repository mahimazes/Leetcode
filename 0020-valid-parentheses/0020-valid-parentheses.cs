public class Solution {
    public bool IsValid(string s) {
       
        Stack<char> stringStack=new Stack<char>();
        
        char temp;
        
        foreach(char c in s)
        {
            if(c==')' || c=='}' || c==']')
            {
                if(stringStack.Count>0)
                {
                   temp=stringStack.Peek();
                
                    if( (temp=='(' && c==')') || ( temp=='{' && c=='}') 
                                              || ( temp=='[' && c==']') )
                    {   
                        stringStack.Pop();
                    }
                    else
                    {
                        stringStack.Push(c);
                    }
                }
                else
                {
                    return false;    
                }
            }
            else
            {
                stringStack.Push(c);
            }
        }
        
        if(stringStack.Count>0)
            return false;
        
        return true;
    }
}