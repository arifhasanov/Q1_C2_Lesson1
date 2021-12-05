internal class PrimeNumberFinder
{
    public PrimeNumberFinder()
    {

    }

    public string PrimeOrNot(int number)
    {
        int d = 0;
        int i = 2;

        while (i < number)
        {
            if (number % i == 0)
            {
                d++;
            }
            i++;
        }

        string result = d == 0 ? "prime" : "non-prime";
        return result;
    }
}
