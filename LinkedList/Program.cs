using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            NodeFunctions nodeFunctions = new NodeFunctions();
            nodeFunctions.AddBefore(10);
            nodeFunctions.AddBefore(12);
            nodeFunctions.AddBefore(11);
            nodeFunctions.AddBefore(9);
            nodeFunctions.AddBefore(11);
            nodeFunctions.AddBefore(11);
            nodeFunctions.List();

            nodeFunctions.Remove(11);
            nodeFunctions.List();

            nodeFunctions.Remove(9);
            nodeFunctions.List();

            nodeFunctions.Remove(12);
            nodeFunctions.List();


        }
    }
}
