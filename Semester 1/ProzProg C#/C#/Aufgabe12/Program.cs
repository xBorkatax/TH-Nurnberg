namespace Aufgabe12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = 3; double n = 0;
            Console.WriteLine("Geben Sie " + limit + " Ganzzahlen ein");
            for (int i = 1; i <= limit; i++) // Schleifenkopf
            {
                string s = Console.ReadLine();
                n += Convert.ToDouble(s);
            }
            Console.WriteLine("Durchschnitt: {0}", n / limit);
        }
    }
}
