namespace Aufgabe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z1 = 5, z2, z3;
            double z4 = 0.5, z5;
            z5 = ++z1 * z4;
            z2 = (int)(z4 + z5);
            z3 = (int)(z2-- * z5);
            Console.WriteLine(z1);
            Console.WriteLine(z2);
            Console.WriteLine(z3);
            Console.WriteLine(z4);
            Console.WriteLine(z5);
        }
    }
}
