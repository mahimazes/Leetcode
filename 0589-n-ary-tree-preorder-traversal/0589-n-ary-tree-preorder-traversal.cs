/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Preorder(Node root) {
        
        List<int> result=new List<int>();
     
        if(root!=null)
        {
            recursivePreorder(root,result);    
        }
        
        return result;
    }
    
    public void recursivePreorder(Node root,List<int> result)
    {
        
        result.Add(root.val);
        
        foreach(var child in root.children)
        {
            recursivePreorder(child,result);
        }
    }
    
}