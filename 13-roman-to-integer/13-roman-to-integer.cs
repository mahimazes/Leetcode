public class Solution {
    public int RomanToInt(string s) {
        
        int sum=0;
        
        IDictionary<char,int> symSet = new Dictionary<char,int>();
        symSet.Add(new KeyValuePair<char,int>('I',1));
        symSet.Add(new KeyValuePair<char,int>('V',5));
        symSet.Add(new KeyValuePair<char,int>('X',10));
        symSet.Add(new KeyValuePair<char,int>('L',50));
        symSet.Add(new KeyValuePair<char,int>('C',100));
        symSet.Add(new KeyValuePair<char,int>('D',500));
        symSet.Add(new KeyValuePair<char,int>('M',1000));
        
        for(int i=0 ;i<s.Length ;i++)
        {
            if(i<s.Length-1 && (symSet[s[i]] < symSet[s[i+1]]))
                sum=sum-symSet[s[i]];
            else
                sum=sum+symSet[s[i]];  
        }
        
        return sum;
        
    }
}