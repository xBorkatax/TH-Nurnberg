class Program
{
    static void Main()
    {
        string inhalt = "";
        string filePath = @"..\..\..\kafka_verwandlung.txt";
        StreamWriter srs = new StreamWriter(filePath); 
        try
        {
            using (StreamReader sr = new StreamReader(filePath))
                
            {
                while (sr.Peek() > 0)
                {
                    inhalt += (char)sr.Read();
                }

            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

        string[] lines = {
                "Alan Mathison Turing (1912-1954) war ein britischer Logiker,",
                "Mathematiker, Kryptoanalytiker und Informatiker.",
                "Das von ihm entwickelte Berechenbarkeitsmodell der Turingmaschine ",
                "bildet eines der Fundamente der Theoretischen Informatik.",
                "Während des Zweiten Weltkrieges war er maßgeblich an der Entzifferung",
                "der mit der deutschen Rotor-Chiffriermaschine Enigma verschlüsselten deutschen Funksprüche beteiligt.",
                "Nach ihm benannt sind der Turing Award, die bedeutendste Auszeichnung in der Informatik,",
                "sowie der Turing-Test zum Überprüfen des Vorhandenseins von künstlicher Intelligenz.",
            };

        ErrechneStatistik(inhalt.Split("\n"));
        //ErrechneStatistik(lines);
    }


    static void ErrechneStatistik(string[] zeilen)
    {
        int anzahlZeilen = zeilen.Length;
        int anzahlWörter = 0;
        int anzahlZeichen = 0;
        int längsteWortlänge = 0;
        int? längstesWortZeile = null;
        int? längstesWortPosition = null;
        int[] häufigkeiten = new int[26];
        int[,] nachfolgerTabelle = new int[26, 26];

        for (int zeile = 0; zeile < zeilen.Length; zeile++)
        {
            string[] wörter = zeilen[zeile].Split(' ');
            for (int position = 0; position < wörter.Length; position++)
            {
                int wortLänge = wörter[position].Length; // zählt punktuation wie . oder , mit
                if (wortLänge > 0) // es kann passieren das leere Wörter auftreten wenn '  ' im text steht
                {
                    if (wortLänge > längsteWortlänge)
                    {
                        längsteWortlänge = wörter[position].Length;
                        längstesWortZeile = zeile;
                        längstesWortPosition = position;
                    }

                    // da der nachfolger des letzten zeichen eines wortes immer ' ' ist
                    // kann es bei der nachfolgerberrechnung weggelassen werden
                    for (int zeichen = 0; zeichen < wortLänge - 1; zeichen++)
                    {
                        int dieserIndex = Index(wörter[position][zeichen]);
                        int nächsterIndex = Index(wörter[position][zeichen + 1]);

                        HäufigkeitUpdaten(dieserIndex, häufigkeiten);
                        NachfolgerUpdaten(dieserIndex, nächsterIndex, nachfolgerTabelle);
                    }
                    // die häufigkeitesberrechnung für das letzte zeichen muss nun nachgeholt 
                    HäufigkeitUpdaten(Index(wörter[position][wortLänge - 1]), häufigkeiten); // bei leerem wort wird der index -1
                }
            }

            anzahlWörter += wörter.Length;
            anzahlZeichen += zeilen[zeile].Length;
        }
        Console.WriteLine("Der Text enthält:");
        Console.WriteLine($" - {anzahlZeilen} Zeilen");
        Console.WriteLine($" - {anzahlWörter} Wörter");
        Console.WriteLine($" - {anzahlZeichen} Zeichen");
        if (längstesWortZeile != null && längstesWortPosition != null)
        {
            Console.WriteLine($"Längstes Wort: '{zeilen[(int)längstesWortZeile].Split(" ")[(int)längstesWortPosition]}' (Zeile {längstesWortZeile + 1}, Position {längstesWortPosition + 1})");
        }
        Console.WriteLine();
        Console.WriteLine("Häufigkeit der Buchstaben:");
        for (int i = 0; i < 26; i++)
        {
            int häufigkeit = häufigkeiten[i];
            if (häufigkeit > 0)
            {
                int indexHäufigsterNachfolger = 0;  // einzige problemfälle einer direkten zuweisung um den compilerfehler zu unterdrücken sind entweder wenn die häufigkeit 0 ist oder wenn der buchstabe nur als letzter im wort vorkommt (unwahrscheinlich genug für jetzt)
                int häufigkeitHäufigsterNachfolger = 0;  // wertzuweisung um compiler zu überzeugen
                for (int j = 0; j < 26; j++)
                {
                    int aktuelleHäufigkeit = nachfolgerTabelle[i, j];
                    if (aktuelleHäufigkeit > häufigkeitHäufigsterNachfolger)
                    {
                        indexHäufigsterNachfolger = j;
                        häufigkeitHäufigsterNachfolger = aktuelleHäufigkeit;
                    }
                }
                Console.WriteLine($"{(char)('a' + i)}:{häufigkeit,7}; Häufigste Kombination: {(char)('a' + i)}{(char)('a' + indexHäufigsterNachfolger)} ({häufigkeitHäufigsterNachfolger}x)");
            }
            else
            {
                Console.WriteLine($"{(char)('a' + i)}:{häufigkeit,7};");
            }
        }

    }

    static void HäufigkeitUpdaten(int index, int[] häufigkeiten)
    {
        if (index >= 0)
        {
            häufigkeiten[index]++;
        }
    }

    static void NachfolgerUpdaten(int dieserIndex, int nächsterIndex, int[,] nachfolgerTabelle)
    {
        if (dieserIndex != -1 && nächsterIndex != -1)
        {
            nachfolgerTabelle[dieserIndex, nächsterIndex]++;
        }
    }

    static int Index(char c)
    {
        if (c >= 'a' && c <= 'z')
            return c - 'a';
        else if (c >= 'A' && c <= 'Z')
            return c - 'A';
        else
            return -1;
    }
}
