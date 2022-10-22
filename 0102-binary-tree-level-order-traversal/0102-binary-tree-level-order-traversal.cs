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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        
        
        List<IList<int>> result=new List<IList<int>>();
        
       if (root == null) return result;
        
      int level=0;
       // RecursiveLevelOrder(root,result);
        
       Queue<TreeNode> q=new Queue<TreeNode>();
       q.Enqueue(root);
        
       while(q.Count>0)
       {
           result.Add(new List<int>());
           
           int level_length=q.Count;
           
           for(int i=0;i<level_length;i++)
           {
                TreeNode node=q.Dequeue();
                
                result[level].Add(node.val);
           
                //if left child is not empty then add it
                if(node.left!=null)
                {
                    q.Enqueue(node.left);    
                }
                //if right child is not empty add it
                if(node.right!=null)
                {
                    q.Enqueue(node.right);
                 }
           
           }
           level++;

       }
        
        
        
        return result;
    }
    
}