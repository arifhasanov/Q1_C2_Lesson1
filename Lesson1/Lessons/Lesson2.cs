class Lesson2
{
    public Lesson2()
    {
        Console.WriteLine("Welcome to Lesson2, here we build doubly linked list and do some operations");
        Console.WriteLine("Lets create a linked list with following values and print the list: 5, 12, 10");
        Console.WriteLine("===================");
        Console.WriteLine();
        LinkedList myList = new LinkedList();
        myList.AddNodeToEnd(5);
        myList.AddNodeToEnd(12);
        myList.AddNodeToEnd(10);
        myList.PrintList();
        Console.WriteLine("===================");
        Console.WriteLine();
        Console.WriteLine("Now lets find a node with value 12");
        Node foundNode = myList.FindNode(12);
        if (foundNode != null)
        {
            Console.WriteLine($"Node value {foundNode.Value}");
        }
        if (foundNode.NextNode != null)
        {
            Console.WriteLine($"Node next node value {foundNode.NextNode.Value}");
        }
        if (foundNode.PrevNode != null)
        {
            Console.WriteLine($"Node previous node value {foundNode.PrevNode.Value}");
        }
        Console.WriteLine("===================");
        Console.WriteLine();
        Console.WriteLine("Now lets add a node to the beginning of the list and print the list: 18");
        myList.AddNodeToBeginning(18);
        myList.PrintList();
        Console.WriteLine("===================");
        Console.WriteLine();
        Console.WriteLine("Now lets find node with value 5: ");
        foundNode = myList.FindNode(5);
        if (foundNode != null)
        {
            Console.WriteLine($"Node value {foundNode.Value}");
        }
        if (foundNode.NextNode != null)
        {
            Console.WriteLine($"Node next node value {foundNode.NextNode.Value}");
        }
        if (foundNode.PrevNode != null)
        {
            Console.WriteLine($"Node previous node value {foundNode.PrevNode.Value}");
        }
        Console.WriteLine("===================");
        Console.WriteLine();
        Console.WriteLine("Now lets delete node with value 5 and print the list:");
        myList.RemoveNode(5);
        myList.PrintList();
        Console.WriteLine("===================");
        Console.WriteLine();
        Console.WriteLine("Now lets add a new value 87 between 12 and 10 and show the list:");
        foundNode = myList.FindNode(12);
        if(foundNode != null)
        {
            myList.AddNodeAfter(foundNode, 87);
            myList.PrintList();
            Console.WriteLine("===================");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No node found with mentioned value");
            Console.WriteLine("===================");
            Console.WriteLine();
        }
        Console.WriteLine("Now lets see how many nodes do we have in the list:");
        Console.WriteLine(myList.Length);
        Console.WriteLine("===================");
        Console.WriteLine();
    }
}
