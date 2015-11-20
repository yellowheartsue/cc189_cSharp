using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._2
{
    class Program
    {//return kth to last: implement an algorithm to find the kth to last elment of a single linked list. 

        static void Main(string[] args)
        {
            //need test later
            
            LinkListNode first = new LinkListNode(0, null, null); 
            LinkListNode head = first;
            LinkListNode second = first;
            for (int i = 1; i < 7; i++)
            {
                second = new LinkListNode(i, null, null);
                first.setNext(second);
                second.setPrevious(first);
                first = second;
            }
      
            for (int i = 0; i <= 7 + 1; i++)
            {
                //Console.WriteLine(kthToLastEleTwoPointer(head, i).data);
                LinkListNode node = kthToLastEle(head, i);
                String nodeValue = node == null ? "null" : "" + node.data;
                Console.WriteLine(nodeValue);
            }
        }

        //method 1, straghit forward, get length, index = length - k + 1, return element at index. O(N) time and O(1) space
        static LinkListNode kthToLastEle(LinkListNode head, int k) {
            LinkListNode n = head;
            int length = 1;

            while (n.next != null) {
                n = n.next;
                length++;
            }

            int index = length - k - 1;

            length = 0 ;
            n = head;
            while (n != null) {
                if (length == index)
                    return n;

                n = n.next;
                length++;
            }

            return null;
        }

        //method 2, recursion. O(n) time, O(n) space, start with counter = 0
        static LinkListNode kthToLastEleRecursive(LinkListNode head, int k, Index idx) {
            if (head == null) {
                return null;
            }
            LinkListNode node = kthToLastEleRecursive(head.next, k, idx);

            idx.value += 1;
            if (idx.value == k)
            {
                return head;
            }

            return node;
        }

        //mehtod 3, 2 pointers, iterative, O(n) time
        static LinkListNode kthToLastEleTwoPointer(LinkListNode head, int k) {
            LinkListNode p1 = head;
            LinkListNode p2 = head;

            for (int i = 0; i < k; i++) {
                if (p2 == null)
                    return null;
                p2 = p2.next;
            }

            while (p2 != null) {
                p1 = p1.next;
                p2 = p2.next;
            }

            return p1;         
        }

        static LinkListNode kthToLastEleRecursive(LinkListNode head, int k) {
            Index idx = new Index();
            return kthToLastEleRecursive(head, k, idx);
        }
    }

    class Index {
        public int value = 0;
    }

    
}
