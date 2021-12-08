class LinkedList : IEnumerable<Node>, ILinkedList
{
    private Node head;
    public Node First { get; set; }

    private Node tail;
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
        throw new NotImplementedException();
    }

    public void AddNode(int data)
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

    public void AddNodeAfter(Node node, int value)
    {
        throw new NotImplementedException();
    }

    public void RemoveNode(int index)
    {
        throw new NotImplementedException();
    }

    public void RemoveNode(Node node)
    {
        throw new NotImplementedException();
    }

    public void PrintList()
    {
        String list = "";
        Node current = head;
        while (current != null)
        {
            list += $"|{current.Value}|-> ";
            current = current.NextNode;
        }

        Console.WriteLine(list);
    }
}
