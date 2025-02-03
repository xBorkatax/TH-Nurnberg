namespace Aufgabe21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berechnung Harmonische Reihe");
            Console.Write("Bis zu welchem n? ");
            int n = int.Parse(Console.ReadLine());

            double sum = 0;
            for (double i = 1; i <= n; i++)
            {
                sum += 1 / i;
            }
            Console.WriteLine($"Summe bis 1/{n}: {sum}");
        }
    }
}
