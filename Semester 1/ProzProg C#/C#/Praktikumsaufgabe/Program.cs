namespace Praktikumsaufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Begrüßungsausgabe
            Console.WriteLine("Djangos Hotel");
            Console.WriteLine("=============");

            // Abfrage
            Console.Write("Wie viel Tage wollen Sie bei uns bleiben? ");
            int numberOfNights = int.Parse(Console.ReadLine()); // Liest die Anzahl der Tage und konvertiert die Eingaben in Int

            // Abfrage der Personenanzahl
            Console.Write("Wie viele Personen sind Sie? ");
            int amountOfPeople = int.Parse(Console.ReadLine()); // Liest die Anzahl der Personen und konvertiert die Eingaben in Int
            Console.WriteLine();

            // Angebot für die Anzahl der Personen und Tage
            Console.WriteLine($"Ihr Angebot für {amountOfPeople} Personen für {numberOfNights} Tage:\n");

            // Anzahl der benötigten Zimmer
            int doubleRoom = amountOfPeople / 2; // Anzahl der Doppelzimmer (2 Personen pro Zimmer)
            int oneRoom = amountOfPeople % 2;    // Anzahl der Einzelzimmer, wenn es eine ungerade Anzahl von Personen gibt

            // Ausgabe der Zimmeranzahl
            Console.WriteLine($"{doubleRoom} Doppelzimmer, {oneRoom} Einzelzimmer \n");


            double price = 0; // Initialisierung des Preises pro Person/Tag
            if (numberOfNights <= 3)
            {
                price = 89.50; // Preis für Aufenthalte bis zu 3 Tagen
            }
            else if (numberOfNights <= 10)
            {
                price = 79.50; // Preis für Aufenthalte von 4 bis 10 Tagen
            }
            else
            {
                price = 60; // Preis für Aufenthalte über 10 Tage
            }

            // Ausgabe des Grundpreises pro Person/Tag
            Console.WriteLine($"Grundpreis p.P./Tag: {price,7:F2}");

            // Berechnung des Gesamtpreises
            double allNightsPrice = price * numberOfNights; // Preis pro Person für die gesamte Aufenthaltsdauer rundet auf 2 Dezimalstellen
            double totalPrice = allNightsPrice * amountOfPeople; // Gesamtpreis für alle Personen

            // Ausgabe der Berechnungen für Tage und Personen
            Console.WriteLine($"  x  {numberOfNights} Tage: {allNightsPrice,15:F2}");
            Console.WriteLine($"  x  {amountOfPeople} Personen: {totalPrice,11:F2}");
            
            // Wenn die Gesamtanzahl an Übernachtungen (Tage x Personen) >= 20 beträgt gibt es einen Rabatt von 10 Prozent
            if (numberOfNights * amountOfPeople >= 20)
            {
                const double discountPercentage = 0.10; // Rabatt in Prozent
                double discount = totalPrice * discountPercentage; // Berechnung des Rabatts
                totalPrice -= discount; // Abziehen des Rabatts vom Gesamtpreis
                Console.WriteLine($"Rabatt 10%: {discount,16:F2}"); // Ausgabe der Berechnungen Rabatt
            }
            
            // Ausgabe des Endbetrags
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Endbetrag: {totalPrice,17:F2}");
        }
    }
}