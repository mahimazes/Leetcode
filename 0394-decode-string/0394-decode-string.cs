public class Solution {
    public string DecodeString(string s) {
        
        Stack<char> stringStack=new Stack<char>();
        string subString="";
        string k="";
        
        for(int i=0;i<s.Length;i++)
        {
            //check if s[i] element is ']', if not append to stack
            if(s[i]!=']')
                stringStack.Push(s[i]);
            else
            {
                subString="";
                //if not then, pop till you come across '['
                while(stringStack.Peek()!='[')
                {
                    subString=stringStack.Pop() +subString;
                }
                stringStack.Pop(); //for '['
               
                k="";
                // pop to find number
                while(stringStack.Count!=0 && Char.IsDigit(stringStack.Peek()))
                {
                   k=stringStack.Pop()+k; 
                }
                
                //multiply as many times as number and push to stack
                subString=string.Concat(Enumerable.Repeat(subString,Int32.Parse(k))); 
                foreach(var c in subString)
                {
                    stringStack.Push(c);
                }
                
            }
     
        }
        
        string result="";
        while(stringStack.Count>0)
        {
            result=stringStack.Pop() +result;
        }
        
        return result;
        
    }
}