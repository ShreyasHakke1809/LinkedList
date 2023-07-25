using System.Collections.Generic;

namespace DSLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program");
            CustomLinkedList customLinkedList = new CustomLinkedList();
            Console.WriteLine("Please choose an option");
            Console.WriteLine("\n1. Create simple linked list \n2. Add element at first position");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
               case 1:           
                 customLinkedList.AddLast(56);
                 customLinkedList.AddLast(30);
                 customLinkedList.AddLast(70);
                 customLinkedList.Display();
                 break;
               case 2:
                 customLinkedList.AddFirst(70);
                 customLinkedList.AddFirst(30);
                 customLinkedList.AddFirst(56);
                 customLinkedList.Display();
                 break;
            }
        }
    }
}