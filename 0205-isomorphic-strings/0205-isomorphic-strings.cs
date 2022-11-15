public class Solution {
    public bool IsIsomorphic(string s, string t) {
        
      /*  List<int> order=new List<int>();
        
        order.Add(1);   //for the first index;
        
        for(int i=1;i<=s.Length-1;i++)
        {
            if((int)s[i-1]>(int)s[i])
            {
                order.Add(0);
            }
            else
            {
                order.Add(1);
            }
        }
        
        for(int i=1;i<=t.Length-1;i++)
        {
            if((int)t[i-1]>(int)t[i] && order.ElementAt(i)==1)
            {
                Console.WriteLine("solution1 "+t[i-1]+" "+t[i]+" "+order.ElementAt(i));
                return false;
            }
            else if((int)t[i-1]<=(int)t[i] && order.ElementAt(i)==0)
            {
                Console.WriteLine("solution2 "+t[i-1]+" "+t[i]+" "+order.ElementAt(i));
                return false;
            }
        }
        
        
        bool AscCheck=false;
        bool DescCheck=false;
        
        if((int)s[0]<=(int)t[0])
        {
            AscCheck=true;
        }
        else
        {
            DescCheck=true;
        }
        
        for(int i=1;i<=s.Length-1;i++)
        {
            if(AscCheck)
            {
                if((int)s[i]>(int)t[i])
                {
                    return false;
                }
            }
            else if(DescCheck)
            {
                if((int)s[i]<(int)t[i])
                {
                    return false;
                }
            }
        }
        */
        
        Dictionary<char,char> map=new Dictionary<char,char>();
        char c;
        
        for(int i=0;i<s.Length;i++)
        {
            if(map.ContainsKey(s[i]))
            {
               if(map[s[i]]!=t[i] )
               {
                   return false;
               }
            }
            else  if(!map.ContainsValue(t[i]))
            {
                map.Add(s[i],t[i]);
               
            }
            else{
                return false;
            }
        }
        
        return true;
        
    }
}
