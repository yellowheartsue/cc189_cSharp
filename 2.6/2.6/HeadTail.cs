using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._6
{
    class HeadTail
    {
        public LinkListNode Head { get; set; }
        public LinkListNode Tail { get; set; }

        public HeadTail(LinkListNode head, LinkListNode tail) {
            this.Head = head;
            this.Tail = tail;
        }

        public HeadTail() { }
    }
}
