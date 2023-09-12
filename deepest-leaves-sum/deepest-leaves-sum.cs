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
    public int DeepestLeavesSum(TreeNode root) {
        
        Queue<TreeNode> q= new Queue<TreeNode>();
        
        if(root==null)
            return 0;
        
        q.Enqueue(root);
        
        int sum=0;
        
        while(q.Count>0)
        {
            
            int len=q.Count;
            int levelSum=0;
            
            for(int i=0;i<len;i++)
            {
                TreeNode node=q.Dequeue();
                
                levelSum=levelSum+node.val;
                
                if(node.left!=null)
                {
                    q.Enqueue(node.left);
                }
                
                if(node.right!=null)
                {
                    q.Enqueue(node.right);
                }
            }
            
            sum=levelSum;
            
        }
        
        return sum;
    }
}