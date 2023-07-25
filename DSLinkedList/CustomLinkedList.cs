using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLinkedList
{
    internal class CustomLinkedList
    {
        public Node head;
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} is inserted into lastnode", newNode.data);
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
                Console.WriteLine("{0} is inserted into lastnode", newNode.data);
            }
        }
        private Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            Console.WriteLine("{0} is inserted into LinkedList", newNode.data);
        }
        public void Display()
        {
            Console.WriteLine("Displaying Nodes:");
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
