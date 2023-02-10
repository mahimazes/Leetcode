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
    public int minDepth(TreeNode root) {
        
        int minvalue=Integer.MAX_VALUE;
       
        return minDepthFun(root,minvalue);
        
    }
    
    public int minDepthFun(TreeNode root, int minvalue)
    {
          if(root==null)
            return 0;
        
        if ((root.left == null) && (root.right == null)) {
            return 1;
         }
        if(root.left!=null)
            minvalue=Math.min(minDepthFun(root.left,minvalue),minvalue);
        if(root.right!=null)
            minvalue=Math.min(minDepthFun(root.right,minvalue),minvalue);
        
        return minvalue+1;
    }
}