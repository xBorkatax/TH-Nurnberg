namespace Aufgabe17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint z = 10;
            for (int i = 10; i > 5; i--)
            {
                --z;
                Console.WriteLine(z--);
            }
        }
    }
}
