public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        
        string smallestString="";
        int Length=200;
        //find smallest str;
        foreach(var str in strs)
        {
            if(str.Length<Length)
            {
                Length=str.Length;
                smallestString=str;
            }
        }
        
        StringBuilder strbuilder=new StringBuilder();
        char temp;
        int pos=0;
        int flag=0;
        
        foreach(var c in smallestString)
        {
            temp=c;
            flag=0;
            foreach(var str in strs)
            {
                if(str[pos]!=temp)
                {
                    flag=1;
                    break;
                }
            }
            
            if(flag==1)
                break;
            
            pos++;
            strbuilder.Append(c);
            
        }
        
        return strbuilder.ToString();
        
    }
}