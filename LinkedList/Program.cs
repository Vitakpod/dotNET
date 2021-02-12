using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string []args)
        {
            Console.WriteLine("How many nodes do you want to add?");
            myLinkedList myList = new myLinkedList();
            string response = Console.ReadLine();
            int num = Int32.Parse(response);

            Random random = new Random();
            myList.InsertHead(myList, (random.Next() % 55));
            myList.printAllNodes(myList);

            /*for (int i = 0; i < num-1; i++)
            {
                Random random = new Random();
                Node newNode = new Node(random.Next() % 55);
                myList.add(newNode)
            }*/

        }
    }
}
