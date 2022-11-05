public class Solution {
    public int CharacterReplacement(string s, int k) {
        
         Dictionary<char, int> freq = new();
        
        int left = 0, maxCount = 0, maxSub = 0;
        for(int i = 0; i < s.Length; i++)
        {
            int val = freq.GetValueOrDefault(s[i], 0);
            val++;
            freq[s[i]] = val; 
            
            maxCount = Math.Max(maxCount, val);
            
            int len = 1 + i - left;
            if(len-maxCount <= k) maxSub = len;
            else
            {
                freq[s[left]]--;
                left++;
            }
        }
        
        return maxSub;
        
      /*  Dictionary<char,int> CharCount=new Dictionary<char,int>();
        
        int left=0,right=0;
        int length=0;
        int result=0;
        
       
        
//if(k==0)
//return CharCount.Values.Max();
        
        while(right<s.Length && left<=right)
        {
            length=right-left+1;

            if((length-CharCount.Values.Max())>k)
            {
                
                 if(CharCount.ContainsKey(s[left]))
                {
                    CharCount[s[left]]--;
                }
                left++;        
               
            }
            right=freq.GetValueOrDefault(s[i], 0)
            CharCount[s[right]]++;
            if(length>result)
            {
                result=length;
            }
           
            right++;            
        }
        
        return result;
        */
        
    }
}