public class Solution {
    int[][] graph;
    int target;
    
    List<IList<int>> result=new List<IList<int>>();
    
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        
        this.graph=graph;
        this.target=graph.Length-1;
        
        List<int> path=new List<int>();
        path.Add(0);
        BackTrack(path,0);
        
        return result;
    }
    
    public void BackTrack(List<int> path, int curr)
    {
        if(curr==target)
        {
            result.Add(new List<int>(path));
            return;
        }
        
        for(int i=0;i<graph[curr].Length;i++)
        {
            path.Add(graph[curr][i]);
            BackTrack(path,graph[curr][i]);
            path.RemoveAt(path.Count-1);
        }
    }
}