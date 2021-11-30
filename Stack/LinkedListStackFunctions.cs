using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class LinkedListStackFunctions
    {
        LinkedList<int> list = new LinkedList<int>();

        public void Push(int value)
        {
            list.AddFirst(value);
        }
        public int Pop()
        {
            if (list.First != null)
            {
                int temp = list.First.Value;
                list.RemoveFirst();
                return temp;
            }
            else
            {
                return -1;
            }
        }
        public int Peek()
        {
            return list.First.Value;
        }


        public void List()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n");
        }
    }
}
