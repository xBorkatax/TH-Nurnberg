namespace Aufgabe10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = a++ - ++a + --a;
            int c = b++ - a--;
            Console.WriteLine(a);

            b = b++ - --c + a;
            c = a = b-- - c-- + ++b;
            Console.WriteLine(b);
        }
    }
}
