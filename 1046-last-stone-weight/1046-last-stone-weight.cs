public class Solution {
    public int LastStoneWeight(int[] stones) {
     
        List<int> stonesList=new List<int>(stones);
        
        int x=0;
        int y=0;
        while(stonesList.Count>1)
        {
            stonesList.Sort((a,b)=>b.CompareTo(a));
            y=stonesList[0];
            x=stonesList[1];

            if(x==y)
            {
                stonesList.RemoveAt(1);
                stonesList.RemoveAt(0);

            }
            else if(x<y)
            {
                y=y-x;
                stonesList.RemoveAt(1);
                stonesList[0]=y;
            }
        
        }
        
        if(stonesList.Count==1)
        {
            return stonesList[0];
        }
        else
            return 0;
    }
}