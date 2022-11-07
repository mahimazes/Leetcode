public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        
        Dictionary<string,int> maps=new Dictionary<string,int>();
        List<string> result=new List<string>();
        
        for(int i=0;i<words.Length;i++)
        {
            if(maps.ContainsKey(words[i]))
            {
                maps[words[i]]++;
            }
            else
            {
                maps.Add(words[i],1);
            }
        }
        
         var pq = new PriorityQueue<string, (int numb, string str)>(Comparer<(int numb, string str)>.Create((f, s) => {
            if(f.numb == s.numb){
                return String.Compare(f.str, s.str);
            }

            return s.numb - f.numb;
        }));
        
        foreach(var (str,count) in maps)
        {
            pq.Enqueue(str,(count,str));
        }
        
        while(k-->0)
        {
            var d=pq.Dequeue();
            result.Add(d);
        }
        
        return result;
    }
}