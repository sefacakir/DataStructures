using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStackFunctions functions = new ArrayStackFunctions();
            functions.Push(10);
            functions.Push(20);
            functions.List();
            functions.Push(30);
            functions.Push(40);
            functions.Push(50);
            functions.List();
            functions.Pop();
            functions.Pop();
            functions.Pop();
            functions.Pop();
            functions.Pop();
            functions.Pop();
            functions.Pop();
            functions.List();

            Console.WriteLine("\n\n\n");

            LinkedListStackFunctions linkedFunctions = new LinkedListStackFunctions();
            linkedFunctions.Push(100);
            linkedFunctions.Push(200);
            linkedFunctions.Push(300);
            linkedFunctions.Push(400);
            

        }
    }
}
