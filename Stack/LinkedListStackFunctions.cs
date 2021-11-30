using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class LinkedListStackFunctions
    {
        LinkedList<int> array = new LinkedList<int>();

        public void Push(int value)
        {
            array.AddFirst(value);
        }
        public void Pop()
        {
            if (array.First != null)
            {
                array.RemoveFirst();
            }
        }
        public void List()
        {
            
        }

        class Program
        {
            static void Main(string[] args)
            {
                LinkedList rehberList = new LinkedList(new Person("Gökhan", "Gökalp", "05554443322", null));

                // Yeni eleman eklenebileceğinden bahsetmiştik şimdi düğüm ekleme mantığına bir bakalım:
                // NextNode parametresini null bıraktığımız için sona ekleyecektir.
                Person secondNode = new Person("Ramazan", "Gökalp", "04443332211", rehberList.FirstNode);
                rehberList.AddNode(secondNode);

                Person thirdNode = new Person("Salih", "Gökalp", "03332221100", secondNode);
                rehberList.AddNode(thirdNode);

                while (rehberList.NextNode())
                {
                    if (rehberList.CurrentNode.FirstName == "Ramazan")
                    {
                        // Bu sayede 2. elemanımız olan Ramazan kişisinden sonra araya Kezban kişisini eklemiş oluyoruz.
                        Person fifthNode = new Person("Kezban", "Ilhan", "07773334422", rehberList.CurrentNode);
                        rehberList.AddNode(fifthNode);
                    }
                }
            }
        }


        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }

            // Kendinden önceki eleman bilgisini verir.
            public Person PrevNode { get; set; }

            // Kendinden sonraki eleman bilgisini verir.
            public Person NextNode { get; set; }

            public Person(string firstName, string lastName, string phoneNumber, Person prevNode)
            {
                FirstName = firstName;
                LastName = lastName;
                PhoneNumber = phoneNumber;

                // Kendinden önceki elemanı verir.
                PrevNode = prevNode;
            }
        }

        public class LinkedList
        {
            // İlk elemanı vermektedir.
            public Person FirstNode { get; set; }

            // Aktif elemanı vermektedir.
            public Person CurrentNode { get; set; }

            // Son elemanı vermektedir.
            public Person LastNode { get; set; }

            public bool _NextNodeFlag = false;

            public LinkedList(Person firstNode)
            {
                // Şuanki eleman ilk elemandır.
                FirstNode = firstNode;
                CurrentNode = firstNode;
                LastNode = firstNode;
            }

            public void AddNode(Person person)
            {
                // Eğer şimdiki elemanın kendinden sonraki elemanı null ise sona ekleyecektir.
                if (CurrentNode.NextNode == null)
                {
                    CurrentNode = CurrentNode.NextNode = person;
                    LastNode = person;
                }
                // Kendinden sonraki elemanı null değil ise araya ekleyecektir.
                else
                {
                    Person tempNextNode = CurrentNode.NextNode;
                    CurrentNode = person;
                    CurrentNode.NextNode = tempNextNode;
                }
            }

            public bool NextNode()
            {
                if (!_NextNodeFlag)
                    CurrentNode = FirstNode;

                if (CurrentNode.NextNode != null)
                {
                    CurrentNode = CurrentNode.NextNode;

                    _NextNodeFlag = true;
                    return true;
                }

                _NextNodeFlag = false;
                return false;
            }
        }
    }
}
