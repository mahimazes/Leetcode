public class Solution {
    public void ReverseString(char[] s) {
       
        int first=0;
        int last=s.Count()-1;
        char temp;
        
        while(first<last)
        {
            temp=s[first];
            s[first]=s[last];
            s[last]=temp;
            
            first++;
            last--;
        }
    }
}