namespace DSLinkedList
{
    internal class CustomLinkedList
    {
        public Node head;

        public void OrderedLinkedlist(int data)
        {
            Node newNode = new Node(data);
            Node currentNode = this.head, temp = null;
            while (currentNode != null && currentNode.data < newNode.data)
            {
                temp = currentNode;
                currentNode = currentNode.next;
            }
            if (temp == null)
            {
                this.head = newNode;
            }
            else
            {
                temp.next = newNode;
            }
            newNode.next = currentNode;
            Console.WriteLine("{0} is inserted into ordered Linkedlist", newNode.data);
        }
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
        public void Append(int data)
        {
            AddLast(data);
        }
        public void Insert(int index, int data)
        {
            Node newNode = new Node(data);
            if (index < 0)
            {
                Console.WriteLine("Invaid index position");
            }
            else if (index == 0)
            {
                AddFirst(data);
            }
            else
            {
                Node temp = this.head;
                for (int i = 0; i < index - 1; i++)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;
            }
        }
        public void DeleteFirst()
        {
            if (head != null)
            {
                head = head.next;
                Console.WriteLine("\nFirst element deleted");
            }
        }
        public void DeleteLast()
        {
            if (head != null && head.next != null)
            {
                Node newNode = head;
                while (newNode.next.next != null)
                {
                    newNode = newNode.next;
                }
                newNode.next = null;
                Console.WriteLine("\nLast element deleted");
            }
            else
                Console.WriteLine("\nLinkedlist is either empty or contains only one element");
        }
        public int FindPosition(int value)
        {
            Node temp = head;
            int index = 0;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    return index;
                }
                temp = temp.next;
                index++;
            }
            return -1;
        }

        public void InsertAfter(int value, int data)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    int position = FindPosition(value);
                    Insert(position + 1, data);
                }
                temp = temp.next;
            }
        }
        public void SearchVaue(int data)
        {
            Node temp = head;
            int search = 0;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    search = 1;
                }
                temp = temp.next;
            }
            if (search == 1)
                Console.WriteLine("\n{0} is present in the linkedlist", data);
            else
                Console.WriteLine("\n{0} is not present in the linkedlist", data);
        }
        public void DeleteParticularElement(int data)
        {
            Node temp = head;
            while (temp.next != null)
            {
                if (temp.next.data == data)
                {
                    temp.next = temp.next.next;
                    Console.WriteLine("\n{0} is Deleted", data);
                }
                temp = temp.next;
            }
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
