using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._7
{
    class LinkListNode
    {
        public LinkListNode next;
        public LinkListNode prev;
        public LinkListNode last;
        public int data;

        public LinkListNode(int d, LinkListNode n, LinkListNode p)
        {
            data = d;
            setNext(n);
            setPrevious(p);
        }

        public LinkListNode(int d)
        {
            data = d;
        }

        public LinkListNode() { }

        public void setNext(LinkListNode n)
        {
            next = n;
            if (this == last)
            {
                last = n;
            }
            if (n != null && n.prev != this)
            {
                n.setPrevious(this);
            }
        }

        public void setPrevious(LinkListNode p)
        {
            prev = p;
            if (p != null && p.next != this)
            {
                p.setNext(this);
            }
        }

        public String printForward()
        {
            if (next != null)
            {
                return data + "->" + next.printForward();
            }
            else
            {
                return data.ToString();
            }
        }

        public LinkListNode clone()
        {
            LinkListNode next2 = null;
            if (next != null)
            {
                next2 = next.clone();
            }
            LinkListNode head2 = new LinkListNode(data, next2, null);
            return head2;
        }
    }
}
