internal class TaskTwo
{
    public string code = @"
public static int  StrangeSum(int[] inputArray)
{
   int sum = 0; // O(1)
   for (int i = 0; i < inputArray.Length; i++) // O(N)
   {
       for (int j = 0; j < inputArray.Length; j++) // O(N^2)
       {
           for (int k = 0; k < inputArray.Length; k++) // O(N^3)
           {
               int y = 0;

               if (j != 0) 
               {
                   y = k / j;
               }

               sum += inputArray[i] + i + k + j + y;
           }
       }
   }

   return sum; // O(1)
}
";
    public TaskTwo()
    {

    }
}
