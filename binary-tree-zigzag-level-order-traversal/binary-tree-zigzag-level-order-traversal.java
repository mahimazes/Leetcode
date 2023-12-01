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
    public List<List<Integer>> zigzagLevelOrder(TreeNode root) {
        
        
        
        Queue<TreeNode> queue=new LinkedList<>();
        List<List<Integer>> result=new ArrayList<>();
        
        if(root==null){
            return result;
        }
        
        queue.add(root);
        
        boolean ltor=false;
        
        while(queue.size()>0)
        {
            int len=queue.size();
            List<Integer> row=new ArrayList<>();
            
            for(int i=0;i<len;i++)
            {
                TreeNode curr=queue.remove();
                
                row.add(curr.val);
                
                if(curr.left!=null)
                    queue.add(curr.left);
                
                if(curr.right!=null)
                    queue.add(curr.right);   
               
            }
            
             if(ltor)
            {
                    Collections.reverse(row);
                    
            }
            ltor=!ltor;
            result.add(row);
                
        }
        
        return result;
        
        
    }
}