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
    public int deepestLeavesSum(TreeNode root) {
    
        Queue<TreeNode> queue=new LinkedList<>();
        
        queue.add(root);
        int sum=0;
        
        while(queue.size()>0)
        {
            int len=queue.size();
            
             sum=0;
            for(int i=0;i<len;i++)
            {
                TreeNode curr=queue.poll();
                sum=sum+curr.val;
                
                if(curr.left!=null)
                {
                    queue.add(curr.left);
                }
                
                if(curr.right!=null)
                {
                    queue.add(curr.right);
                }
            }
        }
        
        return sum;
    }
}