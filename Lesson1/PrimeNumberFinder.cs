internal class PrimeNumberFinder
{
    public PrimeNumberFinder()
    {

    }

    public bool PrimeOrNot(int number)
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

        return d == 0;
    }
}
