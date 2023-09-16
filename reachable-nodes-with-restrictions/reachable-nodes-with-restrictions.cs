public class Solution {
    //int ans=0;
    
    public int ReachableNodes(int n, int[][] edges, int[] restricted) {
        
        //create dictionary graph
        Dictionary<int,List<int>> map=new Dictionary<int,List<int>>();
        HashSet<int> seen=new HashSet<int>();
        
        //preprocess
        
        for(int i=0;i<n;i++)
        {
            map.Add(i,new List<int>());
        }
        
        for(int i=0;i<edges.Length;i++)
        {
            map[edges[i][0]].Add(edges[i][1]);
            map[edges[i][1]].Add(edges[i][0]);
        }
        
        for(int i=0;i<restricted.Length;i++)
        {
            seen.Add(restricted[i]);
        }
        
        //call dfs
        //dfs(0,map,seen);
        
        return dfs(0,map,seen)+1;
        
    }
    
    //dfs will check if node is not seen and if not present in restricted.
    
    int dfs(int src, Dictionary<int,List<int>> map, HashSet<int> seen)
    {
        int ans=0;
        
        if(seen.Contains(src))
        {
            return 0;
        }
        
        seen.Add(src);
        
        foreach(var node in map[src])
        {
            if(!seen.Contains(node))
            {
               // seen.Add(node);
               ans=ans+dfs(node,map,seen)+1;
            }
        }
        
        return ans;
    }
}