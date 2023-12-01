/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    int ans=0;
    public int maxAncestorDiff(TreeNode root) {
        
        if(root==null)
            return 0;
        
        maxAncestorDiffNew(root,root.val,root.val);
        
        return ans;
        
    }
    
    public void maxAncestorDiffNew(TreeNode root, int max, int min)
    {
        if(root==null)
        {
            return;
        }
        
        max=Math.max(max,root.val);
        min=Math.min(min,root.val);
        
        if(Math.max(Math.abs(root.val-max),Math.abs(root.val-min)) > ans)
        {
            ans=Math.max(Math.abs(root.val-max),Math.abs(root.val-min));    
        }
        
        //System.out.println(ans);
        
        maxAncestorDiffNew(root.left,max,min);
        maxAncestorDiffNew(root.right,max,min);
        
        return;
        
    }
}