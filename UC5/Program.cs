using System;

namespace LinkedList_Implimentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wlcome to LinkedList program");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);
            Console.WriteLine("The list before inserting 30 is : ");
            list.Display();
            list.InsertAtParticularPosition(2, 30);
            Console.WriteLine("The list after inserting 30 is : ");
            list.Display();
            list.RemoveFirstNode();
            Console.WriteLine("The list after removing first node is : ");
            list.Display();
        }
    }
}