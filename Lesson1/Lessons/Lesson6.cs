class Lesson6
{
    public void Example()
    {
        Graph<int> genericGraph = Graph<int>.BuidGraph();
        Console.Write("=============================================\n");
        Console.Write("Generic Bi-Directional Graph\n");
        Console.Write("Adjacency List Implementation\n");
        Console.Write("=============================================\n");
        Console.Write(Graph<int>.PrintGraph(genericGraph));
        Console.Write("\n\nType Source Node from list:");
        int source = int.Parse(Console.ReadLine().ToString());// arbitrary source 
        Console.Write(source.ToString());
        Console.Write("\nType Destination Node from list:");
        int destination = int.Parse(Console.ReadLine().ToString()); // arbitrary destination 
        Console.Write(destination.ToString());
        Console.Write("\nSelect Search Type \n 0 for DFS \n 1 for BFS\n");
        SearchType searchType;
        if (int.Parse(Console.ReadLine().ToString()) == 0)
        {
            searchType = SearchType.DFS;
        }
        else if (int.Parse(Console.ReadLine().ToString()) == 1)
        {
            searchType = SearchType.DFS;
        }
        else
        {
            Console.WriteLine("You have entered incorrect search method number");
            return;
        }
        Console.Write((int)searchType + "-" + searchType.ToString());
        Console.Write("\nChecking the path if Reachable from Source node "
            + source + " to Destination node " + destination);
        Console.Write("\n" + searchType.ToString() + " : Path from "
            + source.ToString() + " to " + destination.ToString() + " -> ");
        Console.Write("\n--------------------------------");
        Console.Write(genericGraph.Search(source, destination, genericGraph, searchType));
        Console.Write("=============================================\n");
        Console.WriteLine("Now press ENTER to continue...");
        Console.Read();
    }
}
