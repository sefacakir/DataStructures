using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class LinearProbing
    {
        DataItem[] dataItems;
        int counter;
        public LinearProbing()
        {
            dataItems = new DataItem[20];
        }


        public void Insert(DataItem dataItem)
        {
            counter = 0;
            if (counter == dataItems.Length)
            {
                Console.WriteLine("Table Full!!");
                return;
            }
            int temp = HashFunction(dataItem.Key);
            if (dataItems[temp] == null)
            {
                dataItems[temp] = dataItem;
                counter++;
            }
            else
            {
                while (dataItems[temp] != null)
                {
                    temp++; //her dolu olduğunda bir sonrakine geçip baksın.
                    if (temp > dataItems.Length - 1)
                    {
                        temp = 0;
                    }
                }
                dataItems[temp] = dataItem;
                counter++;
            }
        }

        public void List()
        {
            Console.WriteLine("index, key, value\n-------------------------------");
            for (int i = 0; i < dataItems.Length; i++)
            {
                if (dataItems[i] != null)
                    Console.WriteLine(i + "   " + dataItems[i].Key + "   " + dataItems[i].Value);
            }
            Console.WriteLine("\n");
        }

        public DataItem Search(DataItem dataItem)
        {
            counter = 0;
            int temp = HashFunction(dataItem.Key);
            if (dataItems[temp] == null)
            {
                Console.WriteLine("Search not found!!");
                return null;
            }
            
            while (dataItems[temp].Key != dataItem.Key)
            {
                temp++;
                if (temp > dataItems.Length - 1)
                {
                    temp %= 20;
                }
                if (counter == 20 || dataItems[temp]==null)
                {
                    Console.WriteLine("Search not found.");
                    return null;
                }
                counter++;
            }
            return dataItems[temp];
        }

        public void Delete(DataItem dataItem)
        {
            int temp = HashFunction(dataItem.Key);
            if (dataItems[temp]==null)
            {
                Console.WriteLine("Search not found!!");
                return;
            }
            counter = 0;
            while (dataItems[temp].Key!=dataItem.Key)
            {
                temp++;
                counter++;
                if (temp == dataItems.Length)
                {
                    temp = HashFunction(temp);
                }
                if(counter == dataItems.Length)
                {
                    Console.WriteLine("Search not found!!!");
                    return;
                }
            }

            //bulunması durumunda buraya geçer.
            dataItems[temp] = null;//içeriği temizlendi
            Console.WriteLine(dataItem.Key+" "+dataItem.Value+" silindi.");
        }

        private int HashFunction(int value)
        {
            return value % 20;
        }
    }
}
