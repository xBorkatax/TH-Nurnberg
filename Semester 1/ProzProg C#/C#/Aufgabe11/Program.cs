namespace Aufgabe11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 5745, n;
            n = k++ - 8*56;
            string p;
            Console.WriteLine(n);
            p = n.ToString();
            Console.WriteLine(p);
            p = n.ToString("asad");
            Console.WriteLine("Hello, World!");
            Console.WriteLine(p);
        }
    }
}
