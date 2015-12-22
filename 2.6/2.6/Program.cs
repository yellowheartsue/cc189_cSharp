using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._6
{
    class Program
    {//Palindrom: Implement a function to check if a linked list is a palindrom.

        static void Main(string[] args)
        {
            //3210123
            int[] a1 = new int[] { 3, 2, 1, 0, 1, 2, 3 };
            LinkListNode n3210123 = BuildListWithArray(a1);
            LinkListNode n3210123_clone1 = n3210123.clone();
            LinkListNode n3210123_clone2 = n3210123.clone();

            bool r1 = isPanlindrom(n3210123);
            bool r1half = isPanlindromReverseHalf(n3210123_clone1);
            bool r1r = isPanlindromR(n3210123_clone2);
            Console.WriteLine("Results: {0}, {1}, {2} for Node {3}", r1, r1half, r1r, n3210123.printForward());
           
            //32100123
            int[] a2 = new int[] { 3, 2, 1, 0, 0, 1, 2, 3 };
            LinkListNode n32100123 = BuildListWithArray(a2);
            LinkListNode n32100123_clone1 = n32100123.clone();
            LinkListNode n32100123_clone2 = n32100123.clone();

            bool r2 = isPanlindrom(n32100123);
            bool r2half = isPanlindromReverseHalf(n32100123_clone1);
            bool r2r = isPanlindromR(n32100123_clone2);
            Console.WriteLine("Results: {0}, {1}, {2} for Node {3}", r2, r2half, r2r, n32100123.printForward());

            //4321908
            int[] a3 = new int[] { 4, 3, 2, 1, 9, 0, 8 };
            LinkListNode n4321908 = BuildListWithArray(a3);
            LinkListNode n4321908_clone1 = n4321908.clone();
            LinkListNode n4321908_clone2 = n4321908.clone();

            bool r3 = isPanlindrom(n4321908);
            bool r3half = isPanlindromReverseHalf(n4321908_clone1);
            bool r3r = isPanlindromR(n4321908_clone2);
            Console.WriteLine("Results: {0}, {1}, {2} for Node {3}", r3, r3half, r3r, n4321908.printForward());

        }

        //Method 1: reverse the whole list, check with the original one. O(n) time, O(n) space.
        static bool isPanlindrom(LinkListNode head) {
            LinkListNode reverseNode = head.clone();
            //reverseNode = Reverse(reverseNode);
            reverseNode = ReverseRec(head);

            while (head != null) {
                if (head.data != reverseNode.data)
                    return false;

                reverseNode = reverseNode.next;
                head = head.next;
            }

            return true;
        }


        //Method 2 : reverse only half of the list, using iterative way. O(n) time, O(n) space.
        static bool isPanlindromReverseHalf(LinkListNode head) {
            LinkListNode slow = head;
            LinkListNode fast = head;
            
            Stack<LinkListNode> stack = new Stack<LinkListNode>();
            while ((fast != null) && (fast.next != null)) {
                stack.Push(slow);
                slow = slow.next;
                fast = fast.next.next;
            }


            if (fast != null)
                slow = slow.next;

            while (slow != null) {
                if (slow.data != stack.Pop().data)
                    return false;

                slow = slow.next;
            }

            return true;

            //previous method
            /*
            while ((fast != null) && (fast.next != null))
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            bool move = false;
            if (fast != null)
                move = true;

            fast = head;
            Stack<LinkListNode> stack = new Stack<LinkListNode>();
            while (fast != slow) {
                stack.Push(fast);
                fast = fast.next;
            }

            if (move)
                slow = slow.next;

            while (slow != null) {
                if (slow.data != stack.Pop().data)
                    return false;

                slow = slow.next;
            }
            return true;
             */
        }

        //Method 3, Recursion. O(n) time, O(1) space.
        static bool isPanlindromR(LinkListNode node) {
            LinkListNode head = node;
            return isPanlindromR(head, getLength(node)).Result;   
        }

        static Wrapper isPanlindromR(LinkListNode head, int length) {
            if (head == null || length == 0) {
                return new Wrapper(head, true);
            }

            if (length == 1)
                return new Wrapper(head.next, true);

            Wrapper wap = isPanlindromR(head.next, length - 2);

            if (wap.Node == null || !wap.Result)
                return wap;
            else
                return new Wrapper(wap.Node.next, head.data == wap.Node.data);
        }

        //helper function 
        static LinkListNode ReverseRec(LinkListNode head) {
            return ReverseR(head).Head;
        }

        static HeadTail ReverseR(LinkListNode head) {
            if (head == null)
                return null;
            else {
                HeadTail headTail = ReverseR(head.next);
                if (headTail == null)
                {
                    LinkListNode tail = head.clone();
                    tail.next = null;
                    //LinkListNode returnHead = tail;
                    return new HeadTail(tail, tail);
                }
                else {
                    LinkListNode node = head.clone();
                    node.next = null;
                    headTail.Tail.next = node;
                    return new HeadTail(headTail.Head, node);
                }
            }
        } 

        //helper funcion
        static int getLength(LinkListNode head) {
            int count = 0;
            while (head != null) {
                count += 1;
                head = head.next;
            }

            return count;
        }
        //helper function
        static LinkListNode Reverse(LinkListNode head) {
            Stack<LinkListNode> stack = new Stack<LinkListNode>();
            while (head != null) {
                stack.Push(head);
                head = head.next;
            }

            LinkListNode prev = new LinkListNode();
            LinkListNode newHead = prev;

            while (stack.Count != 0) {
                LinkListNode node = stack.Pop();
                prev.next = node;
                prev = node;
            }
            return newHead.next;
        }

        //helper function
        static LinkListNode BuildListWithArray(int[] array) {
            LinkListNode prev = new LinkListNode();
            LinkListNode head = prev;
            for (int i = 0; i < array.Length; i++) {
                LinkListNode node = new LinkListNode(array[i]);
                prev.next = node;
                prev = node;
            }
            return head.next;
        }
    }
}
