class LinkedList : IEnumerable<Node>, ILinkedList
{
    private Node head;
    private Node tail;

    public Node First { get; set; }
    public Node Last { get; set; }
    public int Length { get; private set; }

    public IEnumerator<Node> GetEnumerator()
    {
        Node current = head;
        while (current != null)
        {
            yield return current;
            current = current.NextNode;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator GetEnumeratorReverse()
    {
        Node current = tail;
        while (current != null)
        {
            yield return current;
            current = current.PrevNode;
        }
    }

    public Node FindNode(int searchValue)
    {
        Node current = head;
        while(current != null)
        {
            if(current.Value == searchValue)
            {
                return current;
            }
            current = current.NextNode;
        }
        return null;
    }

    public int GetCount()
    {
        return Length;
    }

    public void AddNodeToEnd(int data) //Adding node to end
    {
        Node newNode = new Node(data);
        if (tail == null)
        {
            head = newNode;
        }
        else
        {
            newNode.PrevNode = tail;
            tail.NextNode = newNode;
        }
        tail = newNode;
        Length++;
    }

    public void AddNodeToBeginning(int data) //Adding node to front
    {
        Node newNode = new Node(data);
        newNode.NextNode = head;

        if (head == null)
        {
            tail = newNode;
        }
        else
        {
            head.PrevNode = newNode;
        }
        head = newNode;
        Length++;
    }

    public void AddNodeAfter(Node node, int value)
    {
        Node newNode = new Node(value);
        newNode.NextNode = node.NextNode;
        node.NextNode.PrevNode = newNode;
        node.NextNode = newNode;
        Length++;
    }

    public void RemoveNode(int index)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Value == index)
            {
                if(current.NextNode == null) //end of the list
                {
                    tail = current.PrevNode; //removing last item in the list
                }
                else
                {
                    current.NextNode.PrevNode = current.PrevNode; //tie nodes together
                }

                if (current.PrevNode == null) //start of the list
                {
                    head = current.NextNode; //removing first item in the list
                }
                else
                {
                    current.PrevNode.NextNode = current.NextNode; //tie nodes together
                }

                RemoveNode(current);
                Length--;
                return;
            }
            current = current.NextNode;
        }
    }

    public void RemoveNode(Node node)
    {
        node = null;
    }

    public void PrintList()
    {
        String list = "";
        Node current = head;
        while (current != null)
        {
            list += $"<-|{current.Value}|-> ";
            current = current.NextNode;
        }

        Console.WriteLine(list);
    }
}
