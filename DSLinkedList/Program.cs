namespace DSLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program");
            CustomLinkedList customLinkedList = new CustomLinkedList();
            customLinkedList.AddLast(56);
            customLinkedList.AddLast(30);
            customLinkedList.AddLast(70);
            customLinkedList.Display();
        }
    }
}