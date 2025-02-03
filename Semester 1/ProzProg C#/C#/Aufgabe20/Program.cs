namespace Aufgabe20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anzahl Kinder eingeben: ");
            int children = int.Parse(Console.ReadLine());

            Console.Write("Anzahl U-Eier eingeben: ");
            int eggs = int.Parse(Console.ReadLine());

            int eggsProChildern = eggs / children;
            int rest = eggs - (children * eggsProChildern);

            Console.WriteLine($"Es werden {eggsProChildern} pro Kind verteilt, {rest} Eier bleiben ubrig.");
        }
    }
}
