public class BinaryTree
{
    private TreeNode root;

    public void Insert(int data)
    {
        Console.WriteLine($"Inserting {data} ...");
        if (root != null)
        {
            root.Insert(data);
        }
        else
        {
            root = new TreeNode();
            root.data = data;
            root.depth = 1;
        }
    }

    public void Remove(int data)
    {
        TreeNode current = root;
        TreeNode parent = root;
        bool isLeftChild = false;

        if (current == null)
        {
            return;
        }

        while (current != null && current.data != data)
        {
            parent = current;

            if (data < current.data)
            {
                current = current.LeftNode;
                isLeftChild = true;
            }
            else
            {
                current = current.RightNode;
                isLeftChild = false;
            }
        }

        if (current == null)
        {
            return;
        }

        if (current.RightNode == null && current.LeftNode == null)
        {
            if (current == root)
            {
                root = null;
            }
            else
            {
                if (isLeftChild)
                {
                    parent.LeftNode = null;
                }
                else
                {   
                    parent.RightNode = null;
                }
            }
        }
        else if (current.RightNode == null) 
        {
            if (current == root)
            {
                root = current.LeftNode;
            }
            else
            {
                if (isLeftChild)
                {
                    parent.LeftNode = current.LeftNode;
                }
                else
                {   
                    parent.RightNode = current.LeftNode;
                }
            }
        }
        else if (current.LeftNode == null) 
        {
            if (current == root)
            {
                root = current.RightNode;
            }
            else
            {
                if (isLeftChild)
                {  
                    parent.LeftNode = current.RightNode;
                }
                else
                {   
                    parent.RightNode = current.RightNode;
                }
            }
        }
        else
        {
            TreeNode successor = GetSuccessor(current);
            if (current == root)
            {
                root = successor;
            }
            else if (isLeftChild)
            {
                parent.LeftNode = successor;
            }
            else
            {
                parent.RightNode = successor;
            }
        }
    }

    private TreeNode GetSuccessor(TreeNode node)
    {
        TreeNode parentOfSuccessor = node;
        TreeNode successor = node;
        TreeNode current = node.RightNode;

        while (current != null)
        {
            parentOfSuccessor = successor;
            successor = current;
            current = current.LeftNode;
        }
        if (successor != node.RightNode)
        {
            parentOfSuccessor.LeftNode = successor.RightNode;
            successor.RightNode = node.RightNode;
        }
        successor.LeftNode = node.LeftNode;

        return successor;
    }

    public int Height()
    {
        if (root == null)
        { return 0; }

        return root.Height();
    }

    public void BuildTree()
    {
        Lesson4.binaryTreeList = new List<TreeNode>();
        if (root != null)
        {
            root.InOrderTraversal();
        }
    }

    public TreeNode Find(int data)
    {
        if (root != null)
        {
            return root.Find(data);
        }
        else
        {
            return null;
        }
    }
}
