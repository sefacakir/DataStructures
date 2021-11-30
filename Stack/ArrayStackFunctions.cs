using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class ArrayStackFunctions
    {
        int[] array;
        public ArrayStackFunctions()
        {
            array = new int[0];
        }
        public void Push(int value)
        {
            int[] tempArray = new int[array.Length+1];
            if (array.Length != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    tempArray[i] = array[i];
                }
            }
            tempArray[array.Length] = value;
            array = tempArray;
        }

        public int Pop()
        {
            if (array.Length < 1)
            {
                return 0;
            }
            int[] tempArray = new int[array.Length-1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = array[i];
            }
            int temp = array[array.Length - 1];
            array = tempArray;
            return temp;
        }

        public void List()
        {
            foreach (var item in array)
            {
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
