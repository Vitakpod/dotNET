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

            myList.InsertHead(myList, 1);
            int i;

            for (i=1; i < num; i++)
            {
                myList.InsertTail(myList, i+1);
            }
            Console.WriteLine("The list:");
            myList.printAllNodes(myList);

            Console.WriteLine("Adding the node to the head");
            myList.InsertHead(myList, ++i);
            Console.WriteLine("The list:");
            myList.printAllNodes(myList);

            Console.WriteLine("Where do you want to add the node?");
            string response2 = Console.ReadLine();
            int num2 = Int32.Parse(response2);

            myList.InsertAfter(myList, num2,++i );
            Console.WriteLine("The list:");
            myList.printAllNodes(myList);

            Console.WriteLine("Deleting the head:");
            myList.DeleteNode(myList, num+1);
            Console.WriteLine("The list:");
            myList.printAllNodes(myList);

            Console.WriteLine("Deleting the last added node:");
            myList.DeleteNode(myList, i);
            Console.WriteLine("The list:");
            myList.printAllNodes(myList);

            Console.WriteLine("Reversing the list:");
            myList.Reverse(myList);
            Console.WriteLine("The list:");
            myList.printAllNodes(myList);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
