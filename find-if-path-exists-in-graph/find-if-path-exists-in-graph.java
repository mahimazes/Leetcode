class Solution {
    
    Set<Integer> seen=new HashSet<Integer>();
    
    public boolean validPath(int n, int[][] edges, int source, int destination) {
        
        HashMap<Integer,List<Integer>> map=new HashMap<>();
        
        if(n==1)
            return true;
        
        for(int i=0;i<edges.length;i++)
        {
                if(!map.containsKey(edges[i][0]))
                {
                    map.put(edges[i][0],new ArrayList<Integer>());
                }
                if(!map.containsKey(edges[i][1]))
                {
                    map.put(edges[i][1],new ArrayList<Integer>());
                }
                map.get(edges[i][0]).add(edges[i][1]);
                map.get(edges[i][1]).add(edges[i][0]);
        }
        
        dfs(source,map);
        
        return seen.contains(destination);
        
    }
        
    public void dfs(int src, HashMap<Integer,List<Integer>> map)
    {
        seen.add(src);
        
        for(int i:map.get(src))
        {
            if(!seen.contains(i))
            {
                dfs(i,map);
            }
        }
    }
    
}