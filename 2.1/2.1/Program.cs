using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _2._1
{
    class Program
    {//Write code to remove duplicates from an unsorted link. Follow up: how would you solve this problem if a temp buffer is not allowed?

        static void Main(string[] args)
        {
            LinkListNode first = new LinkListNode(0, null, null);
            LinkListNode head = first;
            LinkListNode second = first;
            for (int i = 1; i < 8; i++)
            {
                second = new LinkListNode(i % 2, null, null);
                first.setNext(second);
                second.setPrevious(first);
                first = second;
            }
            LinkListNode cloneA = head.clone();
            LinkListNode cloneB = head.clone();
            Console.WriteLine(cloneA.printForward());
            removeDupe(cloneA);
            Console.WriteLine(cloneA.printForward());

            Console.WriteLine(cloneB.printForward());
            removeDupe2(cloneB);
            Console.WriteLine(cloneB.printForward());
            
        }

        //method: using a hash table
        static void removeDupe(SingleLinkNode head) {
            SingleLinkNode n = head;
            SingleLinkNode prev = null;
            HashSet<int> checker = new HashSet<int>();

            while (n != null) {
                if (checker.Contains(n.data))
                {
                    prev.next = n.next;
                }
                else {
                    checker.Add(n.data);
                    prev = n;
                }
                n = n.next;
            }
        }

        static void removeDupe(LinkListNode head)
        {
            LinkListNode n = head;
            LinkListNode prev = null;
            HashSet<int> checker = new HashSet<int>();

            while (n != null)
            {
                if (checker.Contains(n.data))
                {
                    prev.next = n.next;
                }
                else
                {
                    checker.Add(n.data);
                    prev = n;
                }
                n = n.next;
            }
        }


        //Followup
        //method: keep 2 pointers (runner's tech)
        static void removeDupe2(SingleLinkNode head) {
            SingleLinkNode p1 = head;
            SingleLinkNode p2;
            while (p1 != null) {
                p2 = p1;
                while (p2.next != null) {
                    if (p2.next.data == p1.data) {
                        p2.next = p2.next.next;
                    }

                    p2 = p2.next;
                }
                p1 = p1.next;
            }
        }

        static void removeDupe2(LinkListNode head)
        {
            LinkListNode p1 = head;
            LinkListNode p2;
            while (p1 != null)
            {
                p2 = p1;
                while (p2.next != null)
                {
                    if (p2.next.data == p1.data)
                    {
                        p2.next = p2.next.next;
                    }
                    else
                        p2 = p2.next;
                    
                   
                }
                p1 = p1.next;
            }
        }
    }
}
