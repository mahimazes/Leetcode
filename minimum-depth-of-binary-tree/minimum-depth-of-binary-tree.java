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
        
        if(root==null)
            return 0;
        
        int left=0;
        int right=0;
        if(root.left!=null)
        {
            left=minDepth(root.left);    
        }
        if(root.right!=null)
        {
            right=minDepth(root.right);
        }
        
        if(left!=0 && right!=0)
            return Math.min(left,right)+1;
        
        if(left!=0)
            return left+1;
        
        return right+1;
        
    }
}