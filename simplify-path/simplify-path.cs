public class Solution {
    public string SimplifyPath(string path) {
        
        Stack<string> stack=new Stack<string>();
        
        string[] pathArray=path.Split("/");
        
        for(int i=0;i<pathArray.Length;i++)
        {
           // console.WriteLine(pathArray[i]);
            if(pathArray[i]==".." && stack.Count > 0)
            {
                stack.Pop();
            }
            else if(pathArray[i]!=".." && pathArray[i]!="" && pathArray[i]!=".")
            {
                stack.Push(pathArray[i]);
            }
        }
        
        string ans="";
        if(stack.Count>0)
        {
            while(stack.Count>0)
            {
                ans="/"+stack.Pop()+ans;
            }
        }
        else
            ans="/";
        
        return ans;
        
    }
}