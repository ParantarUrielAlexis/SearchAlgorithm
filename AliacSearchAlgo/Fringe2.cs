using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliacSearchAlgo;

namespace AISearchSample {
    class Fringe2 : Fringes {
        Queue<Node> queue;

        public Fringe2() {
            queue = new Queue<Node>();
        }
        
        public void add(Node n, Node origin) {
            n.Origin = origin;
            queue.Enqueue(n);  
        }

        // Rem
        public Node remove() {
            if (queue.Count != 0)
                return queue.Dequeue();  // Dequ
            return null;
        }
    }
}
