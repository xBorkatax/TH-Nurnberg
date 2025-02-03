using System.Collections.Generic;

namespace Praktikumsaufgabe2
{
    class Program
    {
        static readonly int[] roteZahlen = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
        const double startGuthaben = 200;
        const double startEinsatz = 5;
        const double guthabenLimit = 700;

        double einsatz = 5;
        double guthaben = 200;

        string farbAuswahl = "rot";

        const int anzahlSpieltage = 100;

        // 
        const int ausgabeLevel = 2;

        int anzahlSpieltagGewinne = 0;
        int anzahlIrrelevanterSpieltage = 0;
        double gesamtGewinn = 0;

        Random zufall = new Random();

        static void Main()
        {
            Program program = new Program();
            int spieltag;

            for (spieltag = 1; spieltag <= anzahlSpieltage; spieltag++)
            {
                program.einenSpieltagAusfueren(ausgabeLevel, spieltag);
            }

            Console.WriteLine($"Aus {anzahlSpieltage} Spieltagen wurden {program.anzahlSpieltagGewinne} gewonnen, {anzahlSpieltage - program.anzahlSpieltagGewinne - program.anzahlIrrelevanterSpieltage} verloren und es gingen {program.anzahlIrrelevanterSpieltage} unentschieden aus.");
            Console.WriteLine($"Die Gewinnquote liegt bei {program.anzahlSpieltagGewinne / (double)anzahlSpieltage:F2}");
            Console.WriteLine($"Die Nicht-Verlierquote liegt bei {(program.anzahlSpieltagGewinne + program.anzahlIrrelevanterSpieltage) / (double)spieltag:F2}");
            Console.WriteLine($"Der Gesamtgewinn betraegt {program.gesamtGewinn} Euro.");
        }

        void einenSpieltagAusfueren(int ausgabeLevel, int spieltag)
        {
            if (ausgabeLevel > 0)
            {
                Console.WriteLine("==============================================================================");
                Console.WriteLine($"Spieltag {spieltag,3}, Startguthaben: {startGuthaben,3} Euro, Starteinsatz: {startEinsatz,3} Euro, Limit: {guthabenLimit,3} Euro");
                Console.WriteLine("==============================================================================");
            }
            do
            {
                zufallsZahlUndFarbe(out int zufallsZahl, out string farbe);
                if (farbe == farbAuswahl)
                {
                    guthaben += einsatz;
                    if (ausgabeLevel > 1)
                    {
                        Console.WriteLine($"Einsatz: {einsatz,3} Euro auf {farbAuswahl,3}. Gefallen ist: {zufallsZahl,3}, {farbe,7}. {einsatz,3} Euro gewonnen. Neues Guthaben: {guthaben,3} Euro.");
                    }
                    einsatz = startEinsatz;
                }
                else
                {
                    guthaben -= einsatz;
                    if (ausgabeLevel > 1)
                    {
                        Console.WriteLine($"Einsatz: {einsatz,3} Euro auf {farbAuswahl,3}. Gefallen ist: {zufallsZahl,3}, {farbe,7}. {einsatz,3} Euro verloren. Neues Guthaben: {guthaben,3} Euro.");
                    }
                    einsatz *= 2;
                }
            }
            while (fuertFort());

            if (ausgabeLevel > 0)
            {
                Console.WriteLine($"Endguthaben {guthaben}, Endeinsatz {einsatz}");
                Console.WriteLine();
            }

            if (guthaben > startGuthaben)
            {
                anzahlSpieltagGewinne++;
            }
            else if (guthaben == startGuthaben)
            {
                anzahlIrrelevanterSpieltage++;
            }


            gesamtGewinn += guthaben - startGuthaben;

            guthaben = startGuthaben;
            einsatz = startEinsatz;
        }

        void zufallsZahlUndFarbe(out int zufallsZahl, out string farbe)
        {
            Random zufall = new Random();
            zufallsZahl = zufall.Next(0, 36);

            if (zufallsZahl == 0)
            {
                farbe = "gruen";
            }
            else if (roteZahlen.Contains(zufallsZahl))
            {
                farbe = "rot";
            }
            else
            {
                farbe = "schwarz";
            }
        }

        bool fuertFort()
        {
            return guthaben > 0 && guthaben < guthabenLimit && einsatz <= guthaben;
        }
    }
}
