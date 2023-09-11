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
    int diameter=0;
    public int DiameterOfBinaryTree(TreeNode root) {
        
        if(root==null)
        {
            return 0;
        }
        
        dfs(root,0);
        
        return diameter;
        
    }
    
    public int dfs(TreeNode root, int len)
    {
        if(root==null)
            return len;
    
        int left=dfs(root.left, len);
        int right=dfs(root.right, len);
        diameter=Math.Max(diameter,left+right);

        return Math.Max(left,right)+1;
    }
}