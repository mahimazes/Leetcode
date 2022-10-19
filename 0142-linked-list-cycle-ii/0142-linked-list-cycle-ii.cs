/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        
        HashSet<ListNode> map=new HashSet<ListNode>();
        
        //parse list and store values in map
        ListNode curr=head;
       // if(curr==null)
        //{
         //   return null;
        //}
        
        while(curr!=null)
        {
            //if found then return value associated
            if(map.Contains(curr))
            {
                return curr;
            }
            else{
                map.Add(curr);
            }
            curr=curr.next;
        }
        
        return null;
        
        
    }
}