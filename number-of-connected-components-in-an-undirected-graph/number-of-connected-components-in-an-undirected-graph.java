class Solution {
    
    int ans=0;
    HashSet<Integer> seen=new HashSet<Integer>();
    
    public int countComponents(int n, int[][] edges) {
        
        HashMap<Integer,List<Integer>> map=new HashMap<>();
        
        for(int i=0;i<n;i++)
        {
             
            map.put(i,new ArrayList<Integer>());
     
        }
        
        for(int i=0;i<edges.length;i++)
        {
           
           
            map.get(edges[i][0]).add(edges[i][1]);
            map.get(edges[i][1]).add(edges[i][0]);
            
        }
        
        for(int i=0;i<n;i++)
        {
            if(!seen.contains(i))
            {
                ans++;
                seen.add(i);
                dfs(i,map);
        
            }
        }
        return ans;
        
    }
    
    public void dfs(int src, HashMap<Integer,List<Integer>> map)
    {
        
        for(int i : map.get(src))
        {
            if(!seen.contains(i))
            {
                seen.add(i);
                dfs(i,map);
            }
        }
    }
}