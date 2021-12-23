class Lesson4
{
    public static List<TreeNode> binaryTreeList = new List<TreeNode>();
    public BinaryTree binaryTree = new BinaryTree();
    public void Example()
    {
        Console.WriteLine("Welcome to Lesson 4, here we will examine the Binary Search Tree");
        Console.WriteLine("--------------------------------------------------------");

        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Now lets see the result");
        Console.WriteLine($"The height of the tree is: {binaryTree.Height()}");
        binaryTree.BuildTree();

        OrderList(binaryTree.Height());

        printTree();

        Console.WriteLine("Now let's find a node with data 3");
        TreeNode foundNode = binaryTree.Find(3);
        Console.WriteLine($"Found node data: {foundNode.data}, left node data {foundNode.LeftNode?.data}, right node data: {foundNode.RightNode?.data}");

        Console.WriteLine();

        Console.WriteLine("Now lets delete a node with data 7 and all of its children nodes");
        binaryTree.Remove(7);
        binaryTree.BuildTree();
        OrderList(binaryTree.Height());
        printTree();
    }

    public void FillTree()
    {
        Console.WriteLine("Lets insert some numbers into the tree:");
        binaryTree = new BinaryTree();

        binaryTree.Insert(5);
        binaryTree.Insert(3);
        binaryTree.Insert(7);
        binaryTree.Insert(2);
        binaryTree.Insert(4);
        binaryTree.Insert(6);
        binaryTree.Insert(8);
    }

    private void printTree()
    {
        Console.WriteLine("Here how the tree looks like");
        int height = binaryTree.Height();
        int[] rowNums = new int[binaryTree.Height()];
        for (int i = 0; i < binaryTree.Height(); i++)
        {
            rowNums[i] = height;
            height--;
        }

        foreach (TreeNode node in binaryTreeList)
        {
            Console.WriteLine($"Height: {node.depth}, Own data: {node.data}, Left node: {node.LeftNode?.data}, Right node: {node.RightNode?.data}");
        }
    }

    public string Spaces(int s)
    {
        string spaces = "";
        for (int i = 0; i < s; i++)
        {
            spaces += " ";
        }
        return spaces;
    }

    private void OrderList(int h)
    {
        List<TreeNode> orderedList = new List<TreeNode>();
        for (int i = 1; i <= h; i++)
        {
            foreach (TreeNode node in binaryTreeList)
            {
                if (node.depth == i)
                {
                    orderedList.Add(node);
                }
            }
        }
        binaryTreeList = orderedList;
    }
}
