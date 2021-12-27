public class GraphNode<T>
{
    T value;
    List<GraphNode<T>> neighbors;

    public GraphNode(T value)
    {
        this.value = value;
        this.neighbors = new List<GraphNode<T>>();
    }

    public T Value
    {
        get { return value; }
    }
    public IList<GraphNode<T>> Neighbors
    {
        get { return neighbors.AsReadOnly(); }
    }

    public bool AddNeighbors(GraphNode<T> neighbor)
    {
        if (neighbors.Contains(neighbor))
        {
            return false;
        }
        else
        {
            neighbors.Add(neighbor);
            return true;
        }
    }
    public bool RemoveNeighbors(GraphNode<T> neighbor)
    {
        return neighbors.Remove(neighbor);
    }
    public bool RemoveAllNeighbors()
    {
        for (int i = neighbors.Count; i >= 0; i--)
        {
            neighbors.RemoveAt(i);
        }
        return true;
    }
    public override string ToString()
    {
        StringBuilder nodeString = new StringBuilder();
        nodeString.Append("[ Node Value " + value + " with Neighbors : ");
        for (int i = 0; i < neighbors.Count; i++)
        {
            nodeString.Append(neighbors[i].Value + " ");
        }
        nodeString.Append("]");
        return nodeString.ToString();
    }
}