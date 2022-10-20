public class Solution {
    public int LongestPalindrome(string s) {
        
        Dictionary<char,int> count=new Dictionary<char,int>();
        
        foreach(var c in s)
        {
            if(count.ContainsKey(c))
            {
                count[c]++;
            }
            else{
                count.Add(c,1);
        
            }
        }
        
        int result=0;
        int flag=0;
        //parse through dictionary
        foreach(var pair in count)
        {
            //if(count is 1) then set flag
            if(pair.Value/2 == 0 || pair.Value%2!=0)
            {
                flag=1;
            }
            //if count is divisible by 2, add value to result
            if(pair.Value/2 >0)
            {
                result=result+(pair.Value/2)*2;
            }
        }
        
        result=flag==1 ? result+1: result;
        
        return result;
    }
}