using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._7
{
    class TailAndSize
    {
        public LinkListNode Tail { get; set; }
        public int Size { get; set; }

        public TailAndSize(LinkListNode tail, int size) {
            this.Tail = tail;
            this.Size = size;
        }
    }
}
