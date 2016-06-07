using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._1
{
    class Program
    {
        public enum State {
		    Unvisited, Visited, Visiting
	    } 

        static void Main(string[] args)
        {
            Graph g = createNewGraph();
		    Node[] n = g.getNodes();
		    Node start = n[3];
		    Node end = n[5];
            Console.WriteLine(searchBFS(g, start, end));

            Console.WriteLine(searchDFS(g, start, end));
        }

        public static Graph createNewGraph(){
            Graph g = new Graph();
            Node[] temp = new Node[6];

            temp[0] = new Node("a", 3);
            temp[1] = new Node("b", 0);
		    temp[2] = new Node("c", 0);
		    temp[3] = new Node("d", 1);
		    temp[4] = new Node("e", 1);
		    temp[5] = new Node("f", 0);

            temp[0].addAdjacent(temp[1]);
            temp[0].addAdjacent(temp[2]);
            temp[0].addAdjacent(temp[3]);
            temp[3].addAdjacent(temp[4]);
            temp[4].addAdjacent(temp[5]);

            for(int i = 0; i < 6; i++){
                g.addNode(temp[i]);
            }
            
            return g;
        }

        //BFS
        public static Boolean searchBFS(Graph g, Node start, Node end){
            foreach(Node node in g.getNodes()){
                node.state = State.Unvisited;
            }

            Queue<Node> queue = new Queue<Node>();
            start.state = State.Visiting;
            queue.Enqueue(start);
            Node u;
            while(queue.Count != 0){
                u = queue.Dequeue();
                if( u != null){
                    foreach(Node n in u.getAdjacent()){
                        if(n.state == State.Unvisited){
                            if( n == end)
                                return true;
                            else{
                                n.state = State.Visiting;
                                queue.Enqueue(n);
                            }
                        }
                    }
                    u.state = State.Visited;
                }
            }
            return false;
        }

        //DFS
        public static Boolean searchDFS(Graph g, Node start, Node end) {
            foreach (Node node in g.getNodes())
            {
                node.state = State.Unvisited;
            }

            return searchDFS(start, false, end);
        }

        public static Boolean searchDFS(Node root, Boolean flag, Node end) {
            if (!flag) {
                root.state = State.Visited;
                if (root.getAdjacent() != null && root.getAdjacent().Length != 0) { 
                    foreach(Node n in root.getAdjacent()){
                        if (n.state == State.Unvisited) {
                            if (n == end)
                            {
                                flag = true;
                            }
                            else {
                                flag = searchDFS(n, flag, end);
                            }
                        }
                    }
                }
            }
            return flag;
        }
    }
}
