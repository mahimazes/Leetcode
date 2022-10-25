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
    public bool IsValidBST(TreeNode root) {
        
      
    return RecursiveIsValidBST(root,null,null);
       
        
    }
    
    public bool RecursiveIsValidBST(TreeNode root, int? low,int? high)
    {
        if(root==null)
        {
            return true;
        }
        
        if((low!=null && root.val <= low) || (high!=null && root.val >= high))
        {
            return false;
        }
        
         
        
        return RecursiveIsValidBST(root.left,low,root.val) && RecursiveIsValidBST(root.right,root.val,high);
        
    }
    
    
}