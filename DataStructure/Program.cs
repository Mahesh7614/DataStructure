namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.SortedLinkedList(list.Add(56));
            list.SortedLinkedList(list.Add(30));
            list.SortedLinkedList(list.Add(40));
            list.SortedLinkedList(list.Add(70));

            list.Display();
        }
    }
}