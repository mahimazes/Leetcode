public class Solution {
    public int CountElements(int[] arr) {
        
        HashSet<int> set=new HashSet<int>();
        
        for(int i=0;i<arr.Length;i++)
        {
            set.Add(arr[i]);
        }
        
        int count=0;
        for(int i=0;i<arr.Length;i++)
        {
            if(set.Contains(arr[i]+1))
                count++;
        }
        
        return count;
    }
}