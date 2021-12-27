public class PathNodeInfo<T>
{
    //Graph: internal previous node variable
    GraphNode<T> previous;
    //Graph: constructor to initialize the previous node
    public PathNodeInfo(GraphNode<T> previous)
    {
        this.previous = previous;
    }
    //Graph: Readonly return previous node prop
    public GraphNode<T> Previous
    {
        get
        {
            return previous;
        }
    }
}