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
    public ListNode MiddleNode(ListNode head) {
        
        ListNode singleJump=new ListNode();
        ListNode doubleJump=new ListNode();
        
        singleJump=head;
        doubleJump=head;
        
        while(doubleJump!=null && doubleJump.next!=null)
        {
            singleJump=singleJump.next;
            doubleJump=doubleJump.next.next;
        
        }
        
        return singleJump;
        
    }
}