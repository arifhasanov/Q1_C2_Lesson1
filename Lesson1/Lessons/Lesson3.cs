public class Lesson3
{
    public Lesson3()
    {
        
    }

    public void Example()
    {
        Lesson3HelpingMethods lm = new Lesson3HelpingMethods();
        Console.WriteLine("Welcome to Lesson 3. We will take a look at the calculation of the distance between two points and run a benchmark check for all methods");
        Console.WriteLine();
        Console.WriteLine("Lets first generate 5 different points with struct and see distance between them:");
        lm.GenerateStructRandomPoints();
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Now lets do the same, but with classes:");
        lm.GenerateClassRandomPoints();
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Do you want to run Benchmark? Y/N?");
        if (Console.ReadLine() == "Y")
        {
            Console.WriteLine("Here are the benchmark results for both methods:  ");
            var result1 = BenchmarkRunner.Run<Lesson3HelpingMethods>();
            Console.WriteLine("--------------------------------------------------------");
        }
    }
}
