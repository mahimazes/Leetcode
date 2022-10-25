/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        
       /* int left=1;
        int right=n;
        
        while(left<right)
        {
            int mid=left+(right-left)/2;
            
            if(IsBadVersion(mid))
            {
                right=mid;
            }
            else
            {
                left=mid+1;
            }
        }
        
        return left;
        */
       return RecursiveBadVersion(1,n);
        
    }
    
    public int RecursiveBadVersion(int start,int end)
    {
        
        if(start==end)
        {
            return start;
        }
        
        int mid=start+(end-start)/2;
        
        if(!IsBadVersion(mid))
        {
            return RecursiveBadVersion(mid+1,end);
        }
        else
        {
            return RecursiveBadVersion(start,mid);
        }
    }
}