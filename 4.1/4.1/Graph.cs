using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._1
{
    class Graph
    {
        public static int MAX_VERTICES = 6;
        private Node[] vertices;
        public int count;

        public Graph() {
            vertices = new Node[MAX_VERTICES];
            count = 0;
        }

        public void addNode(Node x) {
            if (count < vertices.Length)
            {
                vertices[count] = x;
                count++;
            }
            else {
                Console.WriteLine("Graph full");
            }
        }

        public Node[] getNodes() { return this.vertices; }
    }
}
