namespace Aufgabe29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gib Zahl: ");
            int zahl = int.Parse(Console.ReadLine());
            Console.Write("Gib Ziffer: ");
            int ziffer = int.Parse(Console.ReadLine());
            int n = EnthaeltZiffer(zahl, ziffer);
            if (n == 0)
            {
                Console.WriteLine($"{zahl} enthaelt kein {ziffer}");
            }
            else
            {
                Console.WriteLine($"{zahl} enthaelt {ziffer} {n} mal");
            }
        }
        static int EnthaeltZiffer(int zahl, int ziffer)
        {
            int count = 0;
            while (zahl > 0)
            {
                if (zahl % 10 == ziffer)
                {
                    count++;
                }
                zahl /= 10;
            }
            return count;
        }
    }
}
