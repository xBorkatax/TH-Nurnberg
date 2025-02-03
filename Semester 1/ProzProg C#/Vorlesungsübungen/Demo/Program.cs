void SpielfeldAusgeben(int[,] spielfeld)
{
    Console.WriteLine();
    Console.Write("    ");
    for (int spalte = 0; spalte < spielfeld.GetLength(0); spalte++)
    {
        Console.Write($"{spalte} ");
    }
    Console.WriteLine();
    Console.Write("  ┌");
    for (int spalte = 0; spalte < spielfeld.GetLength(0); spalte++)
    {
        Console.Write($"──");
    }
    Console.WriteLine();

    for (int zeile = 0; zeile < spielfeld.GetLength(0); zeile++)
    {
        Console.Write($"{zeile} │");

        for (int spalte = 0; spalte < spielfeld.GetLength(1); spalte++)
        {
            Console.Write($" {spielfeld[zeile, spalte]}");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

// Gibt ein array der laenge 4 zurueck, welches die indexgrenzen eines rechteckigen arrays in die richtungen nach index angibt
// 0: in positive spalten richtung
// 1: in positive zeilen richtung
// 2: in positive spalten, positive zeilen richtung (diagonal nach "rechts unten")
// 3: in negative spalten, positive zeilen richtung (diagonal nach "links unten")
bool[] GrenzenErrechnen(int zeile, int spalte, int zeilenAnzahl, int spaltenAnzahl)
{
    int positiveSpaltenRichtungGrenze = spaltenAnzahl - spalte;
    int positiveZeilenRichtungGrenze = zeilenAnzahl - zeile;
    return
    [
        positiveSpaltenRichtungGrenze >= 3,
        positiveZeilenRichtungGrenze >= 3,
        positiveSpaltenRichtungGrenze >= 3 && positiveZeilenRichtungGrenze >= 3,
        spalte >= 2 && positiveZeilenRichtungGrenze >= 3,
    ];
}

// Runtime Error wenn leeres array
bool SindGleich(params int[] array)
{
    int vergleich = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != vergleich) return false;
    }
    return true;
}

int GewinnerErrechnen(int[,] spielfeld, int zeilenAnzahl, int spaltenAnzahl)
{
    for (int zeile = 0; zeile < zeilenAnzahl; zeile++)
    {
        for (int spalte = 0; spalte < spaltenAnzahl; spalte++)
        {
            bool[] grenzen = GrenzenErrechnen(zeile, spalte, zeilenAnzahl, spaltenAnzahl);
            int spieler = spielfeld[zeile, spalte];
            if (spieler != 0)
            {
                if (grenzen[0])
                {
                    if (SindGleich(spieler, spielfeld[zeile, spalte + 1],
                            spielfeld[zeile, spalte + 2]))
                    {
                        return spieler;
                    }
                }

                if (grenzen[1])
                {
                    if (SindGleich(spieler, spielfeld[zeile + 1, spalte], spielfeld[zeile + 2, spalte]))
                    {
                        return spieler;
                    }
                }

                if (grenzen[2])
                {
                    if (SindGleich(spieler, spielfeld[zeile + 1, spalte + 1],
                            spielfeld[zeile + 2, spalte + 2]))
                    {
                        return spieler;
                    }
                }

                if (grenzen[3])
                {
                    if (SindGleich(spieler, spielfeld[zeile + 1, spalte - 1], spielfeld[zeile + 2, spalte - 2]))
                    {
                        return spieler;
                    }
                }
            }
        }
    }

    return 0;
}

// zug ist ein array der länge 3, wobei index 0 der spieler index 1 die zeile und index 2 die spalte ist
// gibt false zurueck wenn der zug ungueltig ist == nichtleeres feld ueberschreibt
bool ZugAusfuehren(int[,] spielfeld, int[] zug)
{
    if (zug[1] <= spielfeld.GetLength(0) && zug[2] <= spielfeld.GetLength(1) && zug[1] > 0 && zug[2] > 0)
    {
        int feld = spielfeld[zug[1], zug[2]];
        if (feld == 0)
        {
            spielfeld[zug[1], zug[2]] = zug[0];
            Console.WriteLine($"Spieler {zug[0]} waehlt das Zeile {zug[1]}, Spalte {zug[2]}");
            return true;
        }
    }
    return false;
}


// sozusagen factory fuer "zug" objekte
// error wenn parse failed
int[] ZugErfragen(int aktuellerSpieler)
{
    Console.WriteLine($"Spieler {aktuellerSpieler} ist dran: ");
    Console.Write("Welche Zeile? ");
    int zeile = int.Parse(Console.ReadLine());
    Console.Write("Welche Spalte? ");
    int spalte = int.Parse(Console.ReadLine());
    return [aktuellerSpieler, zeile, spalte];
}

void SpielzugAusfueren(int aktuellerSpieler, int[,] spielfeld)
{
    int[] zug = ZugErfragen(aktuellerSpieler);

    if (!ZugAusfuehren(spielfeld, zug))
    {
        Console.WriteLine("Ungueltiger Zug!");
        SpielzugAusfueren(aktuellerSpieler, spielfeld);
    }
}


const int zeilenanzahl = 3;
const int spaltenanzahl = 3;

int aktuellerSpieler = 1;
int[,] spielfeld = new int[zeilenanzahl, spaltenanzahl];
SpielfeldAusgeben(spielfeld);

int gewinner = 0;
while (gewinner == 0)
{
    SpielzugAusfueren(aktuellerSpieler, spielfeld);
    SpielfeldAusgeben(spielfeld);

    gewinner = GewinnerErrechnen(spielfeld, zeilenanzahl, spaltenanzahl);
    aktuellerSpieler = aktuellerSpieler == 1 ? 2 : 1;
}

Console.WriteLine($"Spieler {gewinner} gewinnt!");
