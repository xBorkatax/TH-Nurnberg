namespace Aufgabe3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double z1 = 7;
            double z2 = 5;

            z1 /= 2 + (double)(1 / 2);
            z2 /= 2 + 1 / 2.0;

            Console.WriteLine(z1);
            Console.WriteLine(z2);
        }
    }
}
