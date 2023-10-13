public class Solution {
    
    public bool singleDiffChar(string gene1, string gene2)
    {
        int cnt=0;
        for(int i=0;i<gene1.Length;i++)
        {
            if(gene1[i]!=gene2[i])
                cnt++;
        }
        
        return cnt==1;
    }
    
    public int MinMutation(string startGene, string endGene, string[] bank) {
        
        Dictionary<string,List<string>> map=new Dictionary<string, List<string>>();
        
        if(bank.Length==0)
            return -1;
        
        for(int i=0;i<bank.Length;i++)
        {
            for(int j=i+1;j<bank.Length;j++)
            {
                if(singleDiffChar(bank[i],bank[j]))
                {
                    if(!map.ContainsKey(bank[i]))     
                        map.Add(bank[i],new List<string>());
                    
                    if(!map.ContainsKey(bank[j]))
                        map.Add(bank[j],new List<string>());
                    
                    map[bank[i]].Add(bank[j]);
                    map[bank[j]].Add(bank[i]);
                }
            }
        }
        
        for(int i=0;i<bank.Length;i++)
        {
            if(singleDiffChar(bank[i],startGene))
            {
                if(!map.ContainsKey(bank[i]))     
                        map.Add(bank[i],new List<string>());
                    
                if(!map.ContainsKey(startGene))
                        map.Add(startGene,new List<string>());
                    
                    map[bank[i]].Add(startGene);
                    map[startGene].Add(bank[i]);
            }
        }
        
        
        HashSet<string> seenSet=new HashSet<string>();
        
        Queue<string> bfs=new Queue<string>();
        
        bfs.Enqueue(startGene);
        int level=0;
        
        while(bfs.Count()>0)
        {
            int len=bfs.Count();
            level++;    
            for(int i=0;i<len;i++)
            {
                string currGene=bfs.Dequeue();
                seenSet.Add(currGene);
                foreach(var adjGene in map[currGene])
                {
                    if(!seenSet.Contains(adjGene))
                        bfs.Enqueue(adjGene);
                    seenSet.Add(adjGene);
                }
            }
            
            if(seenSet.Contains(endGene))
                return level;
        }
        
        return -1;
        
    }
}