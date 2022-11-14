public class Solution {
    public bool IsHappy(int n) {
        
        HashSet<int> seenSet=new HashSet<int>();
        while(n!=1 && !seenSet.Contains(n))
        {
            seenSet.Add(n);
            n=getNext(n);
        }
        
        return n==1;
    }
    
    public int getNext(int n)
    {
        int totalSum=0;
        while(n>0)
        {
            int d=n%10;
            n=n/10;
            totalSum=totalSum+d*d;
        }
        
        return totalSum;
    }
}