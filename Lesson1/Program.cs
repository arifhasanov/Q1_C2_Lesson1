Console.WriteLine("Welcome to Lesson 1. Which subtask do you want to run?");
Console.WriteLine("1. Finding prime number");
Console.WriteLine("2. Finding asymptotic complexity of the given code");
Console.WriteLine("3. Calculating Fibonacci");

string choice = Console.ReadLine();

if (choice == "1")
{
    Console.WriteLine("WELCOME TO TASK #1: Finding the prime number");
    Console.Write("To see if the number is prime or not please enter a number: ");

    int number = int.Parse(Console.ReadLine().ToString());
    PrimeNumberFinder pm = new PrimeNumberFinder();

    Console.WriteLine($"You have entered a {pm.PrimeOrNot(number)} number");
}
else if (choice == "2")
{
    Console.WriteLine("WELCOME TO TASK #2: Finding asymptotic complexity of the given code");
    Console.WriteLine("Asymptotic complexity (Big O Notation) for the following code is written per each line:");

    TaskTwo t = new TaskTwo();
    Console.WriteLine(t.code);
}
else if (choice == "3")
{
    Console.WriteLine("WELCOME TO TASK #3: Calculating Fibonacci");
    Console.Write("To see the fibonacci result please enter a number of squence: ");

    int sequence = int.Parse(Console.ReadLine().ToString());
    Fibonacci fb = new Fibonacci(sequence);

    Console.WriteLine("Which method do you want to use to calculate the fibonacci?");
    Console.WriteLine("1. Using recursive method");
    Console.WriteLine("2. Using loop method");
    Console.Write("Choice: ");

    string method = Console.ReadLine().ToString();

    if (method == "1")
    {
        Console.WriteLine($"Fibonacci sequence looks like this: {fb.FibonacciWithRecursive(sequence - 1)}");
    }
    else if (method == "2")
    {
        Console.WriteLine($"Fibonacci sequence looks like this: {fb.FibonacciWithLoop(sequence)}");
    }
    else
    {
        Console.WriteLine("Wrong choice. Please choose 1 or 2");
    }
}
else
{
    Console.WriteLine("You have selected incorrect subtask number");
}