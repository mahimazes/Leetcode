/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    int result=0;
    
    public int MaxAncestorDiff(TreeNode root) {
    
        if(root==null)
            return 0;
        
        result=0;
        dfs(root, root.val, root.val);
        return result;
    }
    
    public void dfs(TreeNode root,int MaxVal,int MinVal)
    {
        
        if(root==null)
            return;
        
        int possibleAns=Math.Max(Math.Abs(MaxVal-root.val),Math.Abs(MinVal-root.val));
        result=Math.Max(possibleAns,result);
        
        int currMax=Math.Max(MaxVal,root.val);
        int currMin=Math.Min(MinVal,root.val);
        dfs(root.left,currMax,currMin);
        dfs(root.right,currMax,currMin);
        return;
        
        
        
    }
}