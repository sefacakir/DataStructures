using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Node
    {
        public Node()
        {
            Next = null;
        }
        public Node Next { get; set; }
        public int Number { get; set; }
    }
}
