using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._1
{
    class Node
    {
        private Node[] adjacent;
        public int adjacentCount;
        private String vertex;
        public Program.State state;

        public Node[] getAdjacent() { return this.adjacent; }
        public String getVertex() { return this.vertex; }

        public Node(String vertex, int adjacentLength)
        {
            this.vertex = vertex;
            adjacentCount = 0;
            this.adjacent = new Node[adjacentLength];
        }

        public void addAdjacent(Node x)
        {
            if (this.adjacentCount < this.adjacent.Length)
            {
                this.adjacent[adjacentCount] = x;
                adjacentCount++;
            }
            else
            {
                Console.WriteLine("No more adjacent can be added");
            }
        }
    }
}
