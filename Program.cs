namespace LinkedListTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(10);
            linkedList.AddLast(22);
            linkedList.InsertAtStart(5);


            Console.WriteLine(linkedList.Find(10));

            Console.WriteLine($"\nEmpty: {linkedList.IsEmpty()}");

            Console.WriteLine($"\nFirst Value (head): {linkedList.Head.Value}");
            Console.WriteLine($"\nHead.Next: {linkedList.Head.Next.Value}");

            Console.WriteLine($"\nTail.Previous: {linkedList.Tail.Previous.Value}");
            Console.WriteLine($"\nTail.Value: {linkedList.Tail.Value}");
            linkedList.ListAllNodes();

            linkedList.AddLast(30);
            Console.WriteLine("---------------------------------\nAdded 30 to Last.");
            Console.WriteLine($"\nTail.Value: {linkedList.Tail.Value}");
            Console.WriteLine($"\nTail.Previous: {linkedList.Tail.Previous.Value}");
            linkedList.ListAllNodes();

            Console.WriteLine("-----------------------\nRemoving from Start . . .");
            linkedList.RemoveFromStart();
            Console.WriteLine($"Head.Value: {linkedList.Head.Value}");
            Console.WriteLine($"Head.Next: {linkedList.Head.Next.Value}");

            Console.WriteLine("------------------\n");
            linkedList.ListAllNodes();
        }
    }
}
