namespace Aufgabe19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                int result = 0;
                result = i;
                for (int n = 1; n <= 10; n++)
                {
                    
                    Console.Write($"{result,4}");
                    result += i;
                }
                Console.WriteLine();
            }
        }
    }
}
