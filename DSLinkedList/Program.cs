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
            Console.WriteLine("\n1.Create simple linked list \n2.Add element at first position\n3.Linked list by Appending\n4.Ability to Insert element\n5.Delete first element");
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
               case 3:
                    customLinkedList.Append(56);
                    customLinkedList.Append(30);
                    customLinkedList.Append(70);
                    customLinkedList.Display();
                    break;
               case 4:
                    customLinkedList.Append(56);
                    customLinkedList.Append(70);
                    customLinkedList.Insert(1,30);
                    customLinkedList.Display();
                   break;
               case 5:
                    customLinkedList.Append(56);
                    customLinkedList.Append(70);
                    customLinkedList.Insert(1,30);
                    customLinkedList.Display();
                    customLinkedList.DeleteFirst();
                    customLinkedList.Display();
                    break;
            }
        }
    }
}