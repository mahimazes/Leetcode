public class Solution {
    public IList<IList<int>> FindWinners(int[][] matches) {
        
        Dictionary<int,int> winner=new Dictionary<int,int>();
        
        Dictionary<int,int> loser=new Dictionary<int,int>();
        
        for(int i=0;i<matches.Length;i++)
        {
            if(winner.ContainsKey(matches[i][0]))
            {
                winner[matches[i][0]]=winner[matches[i][0]]+1;
            }
            else
            {
                winner.Add(matches[i][0],1);
            }
            
            if(loser.ContainsKey(matches[i][1]))
            {
                loser[matches[i][1]]=loser[matches[i][1]]+1;
                
            }
            else
            {
                loser.Add(matches[i][1],1);
            }
        }
        
        List<int> array1=new List<int>();
        
        foreach(var pair in winner)
        {
            if(!loser.ContainsKey(pair.Key))
            {
                array1.Add(pair.Key);
            }
        }
        
        List<int> array2=new List<int>();
        
        foreach(var pair in loser)
        {
            if(pair.Value==1)
            {
                array2.Add(pair.Key);
            }
        }
        
        IList<IList<int>> ans=new List<IList<int>>();
        array1.Sort();
        array2.Sort();
        
        ans.Add(array1);
        ans.Add(array2);
        
        return ans;
        
    }
}