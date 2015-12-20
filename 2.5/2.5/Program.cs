using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._5
{
    class Program
    { //Sum lists

        static void Main(string[] args)
        {
            /*
            //99 + 9;
            LinkListNode n99 = new LinkListNode(9);
            n99.next = new LinkListNode(9);
            LinkListNode n9 = new LinkListNode(9);

            LinkListNode n108_1 = sumLists1(n99, n9);
            Console.WriteLine(n99.printForward() + " plus " + n9.printForward() + " equals " + n108_1.printForward());
            LinkListNode n108_R = sumUpRecursion(n99, n9, 0);
            Console.WriteLine(n99.printForward() + " plus " + n9.printForward() + " equals " + n108_R.printForward());
            LinkListNode n108_R2 = sumUpRecursion2(n99, n9, 0);
            Console.WriteLine(n99.printForward() + " plus " + n9.printForward() + " equals " + n108_R2.printForward());
            LinkListNode n108_2 = sumLists2(n99, n9);
            Console.WriteLine(n99.printForward() + " plus " + n9.printForward() + " equals " + n108_2.printForward());
            Console.WriteLine();
           

            //211 + 653
            LinkListNode n211 = new LinkListNode(1);
            n211.next = new LinkListNode(1);
            n211.next.next = new LinkListNode(2);

            LinkListNode n653 = new LinkListNode(3);
            n653.next = new LinkListNode(5);
            n653.next.next = new LinkListNode(6);

            LinkListNode n864_1 = sumLists1(n211, n653);
            Console.WriteLine(n211.printForward() + " plus " + n653.printForward() + " equals " + n864_1.printForward());
            LinkListNode n864_R = sumUpRecursion(n211, n653, 0);
            Console.WriteLine(n211.printForward() + " plus " + n653.printForward() + " equals " + n864_R.printForward());
            LinkListNode n864_R2 = sumUpRecursion2(n211, n653, 0);
            Console.WriteLine(n211.printForward() + " plus " + n653.printForward() + " equals " + n864_R2.printForward());
            LinkListNode n864_2 = sumLists2(n211, n653);
            Console.WriteLine(n211.printForward() + " plus " + n653.printForward() + " equals " + n864_2.printForward());
            Console.WriteLine();
           


            //879 + 586
            LinkListNode n879 = new LinkListNode(9);
            n879.next = new LinkListNode(7);
            n879.next.next = new LinkListNode(8);

            LinkListNode n586 = new LinkListNode(6);
            n586.next = new LinkListNode(8);
            n586.next.next = new LinkListNode(5);

            LinkListNode n1456_1 = sumLists1(n879, n586);
            Console.WriteLine(n879.printForward() + " plus " + n586.printForward() + " equals " + n1456_1.printForward());
            LinkListNode n1456_R = sumUpRecursion(n879, n586, 0);
            Console.WriteLine(n879.printForward() + " plus " + n586.printForward() + " equals " + n1456_R.printForward());
            LinkListNode n1456_R2 = sumUpRecursion2(n879, n586, 0);
            Console.WriteLine(n879.printForward() + " plus " + n586.printForward() + " equals " + n1456_R2.printForward());
            LinkListNode n1456_2 = sumLists2(n879, n586);
            Console.WriteLine(n879.printForward() + " plus " + n586.printForward() + " equals " + n1456_2.printForward());
            Console.WriteLine();
           
            
           

            //586 + 1879
            LinkListNode n1879 = new LinkListNode(9);
            n1879.next = new LinkListNode(7);
            n1879.next.next = new LinkListNode(8);
            n1879.next.next.next = new LinkListNode(1);

            LinkListNode n586n = new LinkListNode(6);
            n586n.next = new LinkListNode(8);
            n586n.next.next = new LinkListNode(5);

            LinkListNode nResult2465_1 = sumLists1(n1879, n586n);
            Console.WriteLine(n1879.printForward() + " plus " + n586n.printForward() + " equals " + nResult2465_1.printForward());
            LinkListNode nResult2465_R = sumUpRecursion(n1879, n586n, 0);
            Console.WriteLine(n1879.printForward() + " plus " + n586n.printForward() + " equals " + nResult2465_R.printForward());
            LinkListNode nResult2465_R2 = sumUpRecursion2(n1879, n586n, 0);
            Console.WriteLine(n1879.printForward() + " plus " + n586n.printForward() + " equals " + nResult2465_R2.printForward());
            LinkListNode nResult2465_2 = sumLists2(n1879, n586n);
            Console.WriteLine(n1879.printForward() + " plus " + n586n.printForward() + " equals " + nResult2465_2.printForward());
            Console.WriteLine();

            //586 + 11879
            LinkListNode n11879 = new LinkListNode(9);
            n11879.next = new LinkListNode(7);
            n11879.next.next = new LinkListNode(8);
            n11879.next.next.next = new LinkListNode(1);
            n11879.next.next.next.next = new LinkListNode(1);

            LinkListNode n586n2 = new LinkListNode(6);
            n586n2.next = new LinkListNode(8);
            n586n2.next.next = new LinkListNode(5);

            LinkListNode nResult12465_1 = sumLists1(n11879, n586n2);
            Console.WriteLine(n11879.printForward() + " plus " + n586n2.printForward() + " equals " + nResult12465_1.printForward());
            LinkListNode nResult12465_R = sumUpRecursion(n11879, n586n2, 0);
            Console.WriteLine(n11879.printForward() + " plus " + n586n2.printForward() + " equals " + nResult12465_R.printForward());
            LinkListNode nResult12465_R2 = sumUpRecursion2(n11879, n586n2, 0);
            Console.WriteLine(n11879.printForward() + " plus " + n586n2.printForward() + " equals " + nResult12465_R2.printForward());
            LinkListNode nResult12465_2 = sumLists2(n11879, n586n2);
            Console.WriteLine(n11879.printForward() + " plus " + n586n2.printForward() + " equals " + nResult12465_2.printForward());
            Console.WriteLine();
            */

            //------------------------------------------------------FOLLOW UP ----------------------------------------------
            //617 + 295 = 912;
            LinkListNode n617 = new LinkListNode(6);
            n617.next = new LinkListNode(1);
            n617.next.next = new LinkListNode(7);

            LinkListNode n295 = new LinkListNode(2);
            n295.next = new LinkListNode(9);
            n295.next.next = new LinkListNode(5);

            LinkListNode n912 = sumFollowUp(n617, n295);
            Console.WriteLine(n617.printForward() + " plus " + n295.printForward() + " equals " + n912.printForward());


            //99 + 9 = 108;
            LinkListNode n99FU = new LinkListNode(9);
            n99FU.next = new LinkListNode(9);
            LinkListNode n9FU = new LinkListNode(9);
            LinkListNode n108FU = sumFollowUp(n99FU, n9FU);
            Console.WriteLine(n99FU.printForward() + " plus " + n9FU.printForward() + " equals " + n108FU.printForward());

            //879 + 586 = 1465
            LinkListNode n879FU = new LinkListNode(8);
            n879FU.next = new LinkListNode(7);
            n879FU.next.next = new LinkListNode(9);

            LinkListNode n586FU = new LinkListNode(5);
            n586FU.next = new LinkListNode(8);
            n586FU.next.next = new LinkListNode(6);

            LinkListNode n1465FU = sumFollowUp(n879FU, n586FU);
            Console.WriteLine(n879FU.printForward() + " plus " + n586FU.printForward() + " equals " + n1465FU.printForward());

            //586 + 11879
            LinkListNode n586FU2 = new LinkListNode(5);
            n586FU2.next = new LinkListNode(8);
            n586FU2.next.next = new LinkListNode(6);

            LinkListNode n11879FU = new LinkListNode(1);
            n11879FU.next = new LinkListNode(1);
            n11879FU.next.next = new LinkListNode(8);
            n11879FU.next.next.next = new LinkListNode(7);
            n11879FU.next.next.next.next = new LinkListNode(9);

            LinkListNode n12465FU = sumFollowUp(n586FU2, n11879FU);
            Console.WriteLine(n586FU2.printForward() + " plus " + n11879FU.printForward() + " equals " + n12465FU.printForward());
        }


        //Method 1: covert into numbers, and convert back. O(n) time, n is the length of the longer list of n1 and n2. O(n) space.
        static LinkListNode sumLists1(LinkListNode n1, LinkListNode n2) {
            int count = 0;
            int sum = 0;
            while (n1 != null) {
               
                sum += n1.data * (int)Math.Pow(10, count);
                count++;
                n1 = n1.next;
            }

            count = 0;
            while (n2 != null) {
                sum += n2.data * (int)Math.Pow(10, count);
                count++;
                n2 = n2.next;
            }

            LinkListNode prev = new LinkListNode();
            LinkListNode head = prev;

            while (sum > 0) {
                LinkListNode n = new LinkListNode(sum % 10);
                prev.next = n;
                prev = n;
                sum = sum / 10;
            }

            return head.next;
        }

        //Method 2: not converting, using padding, and go through both links together. O(n) time, n is the length of longer list. O(n) space.
        static LinkListNode sumLists2(LinkListNode n1, LinkListNode n2) {
            LinkListNode n1head = n1;
            LinkListNode n2head = n2;
            LinkListNode n1head2 = n1;
            LinkListNode n2head2 = n2;
            int l1 = getLength(n1head);
            int l2 = getLength(n2head);

            if (l1 > l2)
                padding(n2head2, l1 - l2);
            else if (l2 > l1)
                padding(n1head2, l2 - l1);

            LinkListNode prev = new LinkListNode();
            LinkListNode head = prev;
            int leftOver = 0;

            while (n1 != null) {
                int n = (n1.data + n2.data + leftOver) % 10;
                leftOver = (n1.data + n2.data + leftOver) / 10;
                

                LinkListNode node = new LinkListNode(n);
                prev.next = node;
                prev = node;

                if (n1.next == null && leftOver == 1) {
                    LinkListNode node2 = new LinkListNode(1);
                    prev.next = node2;
                    prev = n2;

                }

                n1 = n1.next;
                n2 = n2.next;
            }

            return head.next;
        }

        //Method 3: using recursion.
        static LinkListNode sumUpRecursion(LinkListNode n1, LinkListNode n2, int leftover) {
            if (n1 == null && n2 == null) {
                if (leftover == 0)
                    return null;
                else
                    return new LinkListNode(leftover);
            }

            else if (n1 == null && n2 != null) {
                LinkListNode n = new LinkListNode((n2.data + leftover) % 10);
                n.next = sumUpRecursion(null, n2.next, (n2.data + leftover) / 10);
                return n;
            }

            else if (n1 != null && n2 == null) {
                LinkListNode n = new LinkListNode((n1.data + leftover) % 10);
                n.next = sumUpRecursion(n1.next, null, (n1.data + leftover) / 10);
                return n;
            }

            //n1 != null and n2 != null
            else {
                LinkListNode n = new LinkListNode((n1.data + n2.data + leftover) % 10);
                n.next = sumUpRecursion(n1.next, n2.next, (n1.data + n2.data + leftover) / 10);
                return n;
            }
              
        }

        static LinkListNode sumUpRecursion2(LinkListNode n1, LinkListNode n2, int leftover)
        {
            if (n1 == null && n2 == null && leftover == 0)
                return null;

            
            int n = leftover;
            if (n1 != null)
                n += n1.data;
            if (n2 != null)
                n += n2.data;

            LinkListNode node = new LinkListNode( n % 10);

            if(n1 != null || n2 != null)
                node.next = sumUpRecursion2(n1 == null ? null : n1.next, n2 == null ? null : n2.next, (int)(n / 10));

            return node;
        }

        //Follow Up
        static LinkListNode sumFollowUp(LinkListNode n1, LinkListNode n2) {
            int l1 = getLength(n1);
            int l2 = getLength(n2);

            if (l1 > l2)
                n2 = paddingBefore(n2, l1 - l2);
            else if (l2 > l1)
                n1 = paddingBefore(n1, l2 - l1);

            return SumRecursionFollowUp(n1, n2, 0).Node;
        }

        static Wrapper SumRecursionFollowUp(LinkListNode n1, LinkListNode n2, int layer) {
            if(n1 == null && n2 == null)
                return new Wrapper(null, 0);
            else {

                int localLayer = layer;                
                Wrapper wap = SumRecursionFollowUp(n1 == null ? null : n1.next, n2 == null ? null : n2.next, ++layer);
                int value = wap.Leftover;
                if (n1 != null)
                    value += n1.data;
                if (n2 != null)
                    value += n2.data;

                LinkListNode node = new LinkListNode(value % 10);
                node.next = wap.Node;

                //this layer is 0;
                if (localLayer == 0 && value / 10 == 1)
                {
                    LinkListNode node1 = new LinkListNode(1);
                    node1.next = node;

                    Wrapper wappper = new Wrapper(node1, 0);
                    return wappper;
                }

                Wrapper result = new Wrapper(node, value / 10);
                return result;
            }
        }


        static int getLength(LinkListNode head) {
            int l = 0;
            while (head != null) {
                l++;
                head = head.next;
            }

            return l;
        }

        static void padding(LinkListNode head, int n) {
            while (head.next != null) {
                head = head.next;
            }
            for (int i = 0; i < n; i++) {
                LinkListNode zero = new LinkListNode(0);
                head.next = zero;
                head = head.next;
            }
        }

        static LinkListNode paddingBefore(LinkListNode head, int n)
        {
            for (int i = 0; i < n; i++) {
                LinkListNode node = new LinkListNode(0);
                node.next = head;
                head = node;
            }

            return head;
        }
    }

    
}
