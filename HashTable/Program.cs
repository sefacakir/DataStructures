using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearProbing linearProbing = new LinearProbing();

            linearProbing.Insert(new DataItem { Key = 10, Value = 1 });
            linearProbing.Insert(new DataItem { Key = 27, Value = 2 });
            linearProbing.Insert(new DataItem { Key = 100, Value = 3 });
            linearProbing.Insert(new DataItem { Key = 7, Value = 4 });
            linearProbing.Insert(new DataItem { Key = 18, Value = 5 });
            linearProbing.Insert(new DataItem { Key = 19, Value = 6 });
            linearProbing.Insert(new DataItem { Key = 39, Value = 7 });
            linearProbing.List();

            DataItem dataItem = new DataItem
            {
                Value = 7,
                Key = 39
            };
            DataItem dataItem2 = new DataItem
            {
                Key = 40,
                Value = 7
            };
            Console.WriteLine(linearProbing.Search(dataItem));
            Console.WriteLine(linearProbing.Search(dataItem2));

            linearProbing.Delete(dataItem);
            linearProbing.List();

            linearProbing.Insert(dataItem);
            linearProbing.List();
        }
    }
}
