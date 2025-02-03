namespace Aufgabe18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            for (int j = 1; i < 10; i++)
            {
                i = j++ * ++i;
                j = i / ++j;
                j *= 3;
                Console.WriteLine(j);
            }

        }
    }
}
