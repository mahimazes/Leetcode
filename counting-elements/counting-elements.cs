public class Solution {
    public int CountElements(int[] arr) {
        
        HashSet<int> eSet=new HashSet<int>();
        
        for(int i=0;i<arr.Length;i++)
        {
            eSet.Add(arr[i]);
        }
        
        int ans=0;
        for(int i=0;i<arr.Length;i++)
        {
            if(eSet.Contains(arr[i]+1))
            {
                ans++;
            }
            
        }
        
        return ans;
    }
}