namespace Aufgabe13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            for (i = 1; i <= 100; i++) // for( i=3; i <= 100; i += 3)
            {
                //if(i % 3 != 0)
                    //continue;
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
