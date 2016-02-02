using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._7
{
    class Program
    {//determing if 2 lists intersect, return the intersecting node.

        static void Main(string[] args)
        {
            //0 -> 1 -> 2 -> 3 -> 6 -> 7
            //     5 -> 4 -> 3 -> 6 -> 7   
        
            LinkListNode n1 = new LinkListNode(0);
            n1.next = new LinkListNode(1);
            n1.next.next = new LinkListNode(2);

            LinkListNode n2 = new LinkListNode(5);
            n2.next = new LinkListNode(4);
           


            LinkListNode intersect = new LinkListNode(3);
            n1.next.next.next = intersect;
            n2.next.next = intersect;

            intersect.next = new LinkListNode(6);
            intersect.next.next = new LinkListNode(7);

            Console.WriteLine(n1.printForward());
            Console.WriteLine(n2.printForward());

            if (getIntersect(n1, n2) != null)
                Console.WriteLine(getIntersect(n1, n2).printForward());
            else
                Console.WriteLine("not intersacted");
             
            

            LinkListNode n1notintersact = new LinkListNode(0);
            n1notintersact.next = new LinkListNode(1);
            n1notintersact.next.next = new LinkListNode(2);
            n1notintersact.next.next.next = new LinkListNode(3);
            n1notintersact.next.next.next.next = new LinkListNode(6);
            n1notintersact.next.next.next.next.next = new LinkListNode(7);

            LinkListNode n2notintersact = new LinkListNode(5);
            n2notintersact.next = new LinkListNode(4);
            n2notintersact.next.next = new LinkListNode(3);
            n2notintersact.next.next.next = new LinkListNode(6);
            n2notintersact.next.next.next.next = new LinkListNode(7);

            Console.WriteLine(n1notintersact.printForward());
            Console.WriteLine(n2notintersact.printForward());

            if (getIntersect(n1notintersact, n2notintersact) != null)
                Console.WriteLine(getIntersect(n1notintersact, n2notintersact).printForward());
            else
                Console.WriteLine("not intersacted");
        }

        //O(a+b) time, O(1) space
        static LinkListNode getIntersect(LinkListNode n1, LinkListNode n2) {
            LinkListNode head1 = n1;
            LinkListNode head2 = n2;
            TailAndSize s1 = getTailandSize(n1);
            TailAndSize s2 = getTailandSize(n2);

            if (s1.Tail == s2.Tail)
            {
                LinkListNode longer = s1.Size > s2.Size ? head1 : head2;
                LinkListNode shorter = s1.Size < s2.Size ? head1 : head2;

                longer = getKthNode(longer, Math.Abs(s1.Size - s2.Size));

                while (longer != shorter) {
                    longer = longer.next;
                    shorter = shorter.next;
                }

                return longer;

            }
            else 
                return null;   
        }

        static TailAndSize getTailandSize(LinkListNode node){
            int i = 1;
            while(node.next != null){
                ++i;
                node = node.next;
            }

            return new TailAndSize(node, i);
        }

        static LinkListNode getKthNode(LinkListNode node, int k) {
            while (k > 0) {
                node = node.next;
                k--;
            }

            return node;
        }
    }
}
