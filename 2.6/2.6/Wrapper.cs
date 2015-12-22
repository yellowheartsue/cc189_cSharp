using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._6
{
    class Wrapper
    {
        public LinkListNode Node { get; set; }
        public bool Result { get; set; }

        public Wrapper(LinkListNode node, bool result) {
            this.Node = node;
            this.Result = result;
        }

        public Wrapper() { }
    }
}
