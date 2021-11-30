using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class NodeFunctions
    {
        Node start, temp;
        
        public void AddFirst(int value)
        {
            if (start == null)
            {
                start = new Node();
                start.Number = value;
            }
            else
            {
                temp = new Node();
                temp.Next = start;
                temp.Number = value;
                start = temp;
            }
        }
        
        public void AddLast(int value)
        {
            if (start == null)
            {
                AddFirst(value);
            }
            else
            {
                temp = start;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                Node node = new Node();
                node.Number = value;
                temp.Next = node;
            }
        }
        
        public void AddBefore(int value)
        {
            if (start == null || start.Number > value)
            {
                AddFirst(value);
                return;
            }
            Node node = new Node();
            if (start.Next == null) //eğer tek düğüm ise ya başa ekleme yada sona ekleme yapılacak.
            {
                if (start.Number < value)
                {
                    AddLast(value);
                    return;
                }
                else
                {
                    AddFirst(value);
                    return;
                }
            }
            temp = start;
            while (temp.Next != null)
            {
                if (temp.Next.Number > value)
                {
                    node.Next = temp.Next;
                    node.Number = value;
                    temp.Next = node;
                    return;
                }
                temp = temp.Next;
            }
            AddLast(value);
        }
        
        public void Remove(int value)
        {
            temp = start;
            if (start == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            if (start.Number == value) //first node control
            {
                start = start.Next;
                return;
            }
            if (temp.Next.Next == null) //if there are only two nodes
            {
                if (temp.Next.Number == value) //if the last node
                {
                    temp.Next = null;
                    return;
                }
            }
            else //if there are more than 2 nodes
            {
                while (temp.Next.Next != null)
                {
                    if (temp.Next.Number == value)
                    {
                        temp.Next = temp.Next.Next;
                        return;
                    }
                    temp = temp.Next;
                }
                if (temp.Next.Number == value)
                {
                    temp.Next = null;
                }
            }
        }
        
        public void List()
        {
            temp = start;
            while (temp != null)
            {
                Console.WriteLine(temp.Number);
                temp = temp.Next;
            }
            Console.WriteLine("\n\n");
        }
    }
}
