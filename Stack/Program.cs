using System;

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

            LinkedListStackFunctions listFunctions = new LinkedListStackFunctions();
            listFunctions.Push(100);
            listFunctions.Push(200);
            listFunctions.Push(300);
            listFunctions.Push(400);
            listFunctions.List();
            Console.WriteLine(listFunctions.Peek()+"\n\n");

            listFunctions.Pop();
            listFunctions.Pop();
            listFunctions.List();


        }
    }
}
