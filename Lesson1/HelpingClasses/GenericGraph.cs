
public enum SearchType
{
    DFS,
    BFS
}

public class Graph<T>
{
    List<GraphNode<T>> nodes = new List<GraphNode<T>>();

    public Graph()
    {

    }

    public int Count
    {
        get
        {
            return nodes.Count;
        }
    }
    public IList<GraphNode<T>> Nodes
    {
        get
        {
            return nodes.AsReadOnly();
        }
    }

    public bool AddNode(T value)
    {
        if (Find(value) != null)
        {
            //duplicate value
            return false;
        }
        else
        {
            nodes.Add(new GraphNode<T>(value));
            return true;
        }
    }
    public bool AddEdge(T value1, T value2)
    {
        GraphNode<T> node1 = Find(value1);
        GraphNode<T> node2 = Find(value2);
        if (node1 == null || node2 == null)
        {
            return false;
        }
        else if (node1.Neighbors.Contains(node2))
        {
            return false;
        }
        else
        {
            node1.AddNeighbors(node2);
            node2.AddNeighbors(node1);
            return true;
        }
    }
    public GraphNode<T> Find(T value)
    {
        foreach (GraphNode<T> node in nodes)
        {
            if (node.Value.Equals(value))
            {
                return node;
            }
        }
        return null;
    }
    public bool RemoveNode(T value)
    {
        GraphNode<T> removeNode = Find(value);
        if (removeNode == null)
        {
            return false;
        }
        else
        {
            nodes.Remove(removeNode);
            foreach (GraphNode<T> node in nodes)
            {
                node.RemoveNeighbors(removeNode);
            }
            return true;
        }
    }
    public bool RemoveEdge(T value1, T value2)
    {
        GraphNode<T> node1 = Find(value1);
        GraphNode<T> node2 = Find(value2);
        if (node1 == null || node2 == null)
        {
            return false;
        }
        else if (!node1.Neighbors.Contains(node2))
        {
            return false;
        }
        else
        {
            node1.RemoveNeighbors(node2);
            node2.RemoveNeighbors(node1);
            return true;
        }
    }
    public void Clear()
    {
        foreach (GraphNode<T> node in nodes)
        {
            node.RemoveAllNeighbors();
        }
        for (int i = nodes.Count - 1; i >= 0; i--)
        {
            nodes.RemoveAt(i);
        }
    }
    public override string ToString()
    {
        StringBuilder nodeString = new StringBuilder();
        for (int i = 0; i < Count; i++)
        {
            nodeString.Append(nodes[i].ToString());
            if (i < Count - 1)
            {
                nodeString.Append("\n");
            }
        }
        return nodeString.ToString();
    }

    public static Graph<int> BuidGraph()
    {
        Graph<int> graph = new Graph<int>();
        graph.AddNode(1);
        graph.AddNode(4);
        graph.AddNode(5);
        graph.AddNode(7);
        graph.AddNode(10);
        graph.AddNode(11);
        graph.AddNode(12);
        graph.AddNode(42);

        graph.AddEdge(1, 5);
        graph.AddEdge(4, 11);
        graph.AddEdge(4, 42);
        graph.AddEdge(5, 11);
        graph.AddEdge(5, 12);
        graph.AddEdge(5, 42);
        graph.AddEdge(7, 10);
        graph.AddEdge(7, 11);
        graph.AddEdge(10, 11);
        graph.AddEdge(11, 42);
        graph.AddEdge(12, 42);
        return graph;
    }

    public static string PrintGraph(Graph<T> graph)
    {
        return graph.ToString();
    }

    public string Search(int start, int finish, Graph<int> graph, SearchType searchType)
    {
        LinkedList<GraphNode<int>> searchList = new LinkedList<GraphNode<int>>();
        if (start == finish)
        {
            return start.ToString();
        }
        else if (graph.Find(start) == null || graph.Find(finish) == null)
        {
            return "";
        }
        else
        {
            GraphNode<int> startNode = graph.Find(start);
            Dictionary<GraphNode<int>, PathNodeInfo<int>> pathNodes = new Dictionary<GraphNode<int>, PathNodeInfo<int>>();
            pathNodes.Add(startNode, new PathNodeInfo<int>(null));
            searchList.AddFirst(startNode);

            while (searchList.Count > 0)
            {
                //extract front of search list
                GraphNode<int> currentNode = searchList.First.Value;
                searchList.RemoveFirst();

                //explore each neighbour of this node
                foreach (GraphNode<int> neighbor in currentNode.Neighbors)
                {
                    if (neighbor.Value == finish)
                    {
                        pathNodes.Add(neighbor, new PathNodeInfo<int>(currentNode));
                        return "\nFinal Path is " + CovertPathToString(neighbor, pathNodes);
                    }
                    else if (pathNodes.ContainsKey(neighbor))
                    {
                        //check for cycle, skip this neighbour
                        continue;
                    }
                    else
                    {
                        pathNodes.Add(neighbor, new PathNodeInfo<int>(currentNode));
                        if (searchType == SearchType.DFS)
                        {
                            searchList.AddFirst(neighbor);
                        }
                        else
                        {
                            searchList.AddLast(neighbor);
                        }
                        Console.Write("\nJust Added " + neighbor.Value + " to search list");
                    }
                }
            }
            //didn't find a path from start to finish
            return "";
        }
    }
    public static string CovertPathToString(GraphNode<int> endNode, Dictionary<GraphNode<int>, PathNodeInfo<int>> pathNodes)
    {
        //build ll for path in the correct order
        LinkedList<GraphNode<int>> path = new LinkedList<GraphNode<int>>();
        path.AddFirst(endNode);
        GraphNode<int> previous = pathNodes[endNode].Previous;
        while (previous != null)
        {
            path.AddFirst(previous);
            previous = pathNodes[previous].Previous;
        }

        //build and return string
        StringBuilder pathString = new StringBuilder();
        LinkedListNode<GraphNode<int>> currentNode = path.First;
        int nodeCount = 0;
        while (currentNode != null)
        {
            nodeCount++;
            pathString.Append(currentNode.Value.Value);
            if (nodeCount < path.Count)
            {
                pathString.Append(" ");

            }
            currentNode = currentNode.Next;
        }
        return pathString.ToString();
    }
}