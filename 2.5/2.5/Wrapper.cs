using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._5
{
    class Wrapper
    {
        public LinkListNode Node { get; set; }
        public int Leftover { get; set; }
       // public int Layer { get; set; }

        public Wrapper(LinkListNode node, int leftover){
            this.Node = node;
            this.Leftover = leftover;
            //this.Layer = layer;
        }

        public Wrapper() { }
    }
}
