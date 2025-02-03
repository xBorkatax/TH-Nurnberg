namespace Aufgabe27
{
    class Program
    {
        // Prüft, ob zahl ziffern enthält
        // Bei genau1 wird nur dann true zurückgeliefert,
        // wenn die ziffer genau 1x enthalten
        static bool Enthaelt(int zahl, int ziffer, bool genau1 = false)
        {
            int anzahl = 0;

            while (zahl > 0)
            {
                int letzteZiffer = zahl % 10;
                if (letzteZiffer == ziffer)
                    anzahl++;
                zahl /= 10;
            }

            if (genau1)
                return anzahl == 1;
            else
                return anzahl > 0;
        }

        // Hauptprogramm
        static void Main(string[] args)
        {
            Console.Write("Untere Grenze eingeben: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Obere Grenze eingeben: ");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int zahl = a; zahl <= b; zahl++)
            {
                if (Enthaelt(zahl, 7, true))
                    Console.WriteLine(zahl);
            }
        }
    }

}
