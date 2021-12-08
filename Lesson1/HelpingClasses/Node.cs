class Node
{
    public int Value { get; set; }
    public Node NextNode { get; set; }
    public Node PrevNode { get; set; }

    public Node(int data)
    {
        Value = data;
    }
}
