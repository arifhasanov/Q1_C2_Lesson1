class Lesson5
{
    public void Example()
    {
        Console.WriteLine("Welcome to Lesson 5, here we will further examine the Binary Search Tree");
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("First we fill the tree with the data");
        Console.WriteLine();
        Lesson4 l4 = new Lesson4();
        l4.FillTree();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Now we search the tree nodes by width (BFS)");
        l4.binaryTree.BreadthFirstSearch();
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Next we search the tree nodes by depth (DFS)");
        l4.binaryTree.DepthFirstSearch();
        Console.ReadLine();
    }
}
