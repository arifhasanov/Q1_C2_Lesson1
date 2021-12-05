internal class Fibonacci
{
    public int sequence { get; set; }
    public Fibonacci(int s)
    {
        sequence = s;
    }

    public int FibonacciWithRecursive(int s)
    {
        if ((s == 0) || (s == 1))
        {
            return s;
        }
        else
        {
            return FibonacciWithRecursive(s - 1) + FibonacciWithRecursive(s - 2);
        }
    }

    public int FibonacciWithLoop(int s)
    {
        int a = 0, b = 1, c = 0;
        for (int i = 2; i < s; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }
}
