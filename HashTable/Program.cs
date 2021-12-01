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


            Console.WriteLine(linearProbing.Search(new DataItem { Key = 39, Value = 7 }).Key);
            Console.WriteLine(linearProbing.Search(new DataItem { Key = 40, Value = 7 }));






        }
    }
}
