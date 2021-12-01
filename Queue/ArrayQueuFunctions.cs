using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class ArrayQueuFunctions
    {
        int[] array;
        public ArrayQueuFunctions()
        {
            array = new int[0];
        }
        public bool isEmpty()
        {
            if (array.Length == 0)
            {
                return true;
            }
            else return false;
        }
        public void Enqueue(int value)
        {
            int[] tempArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[array.Length] = value;
            array = tempArray;
        }
        public int Dequeue()
        {
            if (isEmpty())
            {
                return -1;
            }

            int temp = array[array.Length - 1];
            int[] tempArray = new int[array.Length - 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = array[i+1];
            }
            array = tempArray;
            return temp;
        }

        public void List()
        {
            foreach (var item in array)
            {
                Console.Write(item+"  ");
            }
            Console.WriteLine("\n");
        }
    }
}
