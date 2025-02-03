namespace Aufgabe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char c = 'c';

            a = (int)c;
            b = (char)a;
            Console.WriteLine($"a: {a}, b: {b}");
        }
    }
}
