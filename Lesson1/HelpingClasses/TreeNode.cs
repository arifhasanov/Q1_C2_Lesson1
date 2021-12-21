public class TreeNode
{
    public int data;
    public int depth;

    private TreeNode rightNode;
    public TreeNode RightNode
    {
        get { return rightNode; }
        set { rightNode = value; }
    }

    private TreeNode leftNode;
    public TreeNode LeftNode
    {
        get { return leftNode; }
        set { leftNode = value; }
    }

    public void Insert(int value)
    {
        if (value >= data)
        { 
            if (rightNode == null)
            {
                rightNode = new TreeNode();
                rightNode.data = value;
                rightNode.depth += (depth + 1);
            }
            else
            {
                rightNode.Insert(value);
            }
        }
        else
        {
            if (leftNode == null)
            {
                leftNode = new TreeNode();
                leftNode.data = value;
                leftNode.depth += (depth + 1);
            }
            else
            {
                leftNode.Insert(value);
            }
        }
    }

    public int Height()
    {
        if (this.leftNode == null && this.rightNode == null)
        {
            return 1;
        }

        int left = 0;
        int right = 0;

        if (this.leftNode != null)
        {
            left = this.leftNode.Height();
        }
        if (this.rightNode != null)
        {
            right = this.rightNode.Height();
        }

        if (left > right)
        {
            return (left + 1);
        }
        else
        {
            return (right + 1);
        }
    }

    public void InOrderTraversal()
    {
        if(leftNode != null)
        {
            leftNode.InOrderTraversal();
        }
        
        Lesson4.binaryTreeList.Add(this);
        //Console.WriteLine($"Height: {Height()}, Own data: {data}, Left node: {this.LeftNode?.data}, Right node: {this.rightNode?.data}");

        if (rightNode != null)
        {
            rightNode.InOrderTraversal();
        }
    }

    public TreeNode Find(int value)
    {
        TreeNode currentNode = this;

        while (currentNode != null)
        {
            if (value == currentNode.data)
            {
                return currentNode;
            }
            else if (value > currentNode.data)
            {
                currentNode = currentNode.rightNode;
            }
            else
            {
                currentNode = currentNode.leftNode;
            }
        }
        //Node not found
        return null;
    }
}

