using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayQueuFunctions functions = new ArrayQueuFunctions();
            functions.Enqueue(5);
            functions.Enqueue(15);
            functions.Enqueue(8);
            functions.Enqueue(20);
            functions.List();

            functions.Dequeue();
            functions.Dequeue();
            functions.List();

            functions.Enqueue(35);
            functions.Enqueue(45);
            functions.Enqueue(55);
            functions.List();
            
            functions.Dequeue();
            functions.Dequeue();
            functions.List();
        }
    }
}
