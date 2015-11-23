using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._3
{
    class Program
    { //Delete middle node: Implement an algorithm to delete a node in the middle of a single linked list, given only access to that node.
        static void Main(string[] args) {


            LinkListNode head = new LinkListNode(0);
            LinkListNode first = head;
            for(int i = 1; i < 10; i++){
                LinkListNode second = new LinkListNode(i);
                first.setNext(second);
                first = second;
            }

            Console.WriteLine(head.printForward());

            Delete(head.next.next.next.next.next);

            Console.WriteLine(head.printForward());
        }

        //method 1: copy next node to n, delete next node, O(1) time, O(1) space
        static bool Delete(LinkListNode n){
            if (n.next == null || n == null)
                return false;
            else {
                n.data = n.next.data;
                n.next = n.next.next;
                return true;
            }
        }
    }
}
