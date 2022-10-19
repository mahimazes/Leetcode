/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        
        ListNode prev=new ListNode();
        ListNode curr,temp;
        
        if(head==null)
            return null;
        
        prev=head;
        curr=prev.next;
        
        while(curr!=null)
        {
            //if head node
            if(prev==head)
            {
                prev.next=null;
            }
            
            temp=curr.next;
            //if middle node
            curr.next=prev;
            prev=curr;
            curr=temp;
        }
        
        return prev;
    }
}