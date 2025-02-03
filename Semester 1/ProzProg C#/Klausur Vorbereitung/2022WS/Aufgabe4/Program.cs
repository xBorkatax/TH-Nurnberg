using System;
using System.IO;

class Leuchtturm
{
    // Funktion, um den nächstgelegenen sichtbaren Leuchtturm zu finden
    public static string NächsterLeuchtturm(double schiffX, double schiffY)
    {
        string nächsterLeuchtturm = null;
        double kleinsteDistanz = double.MaxValue;

        try
        {
            // Datei manuell öffnen und Zeilen einlesen
            using (StreamReader reader = new StreamReader("lights.txt"))
            {
                string zeile;
                while ((zeile = reader.ReadLine()) != null)
                {
                    string[] teile = zeile.Split('|');

                    string nummer = teile[0].Trim();
                    string name = teile[1].Trim();
                    string[] position = teile[2].Trim().Split(';');
                    int reichweite = int.Parse(teile[3].Trim());

                    // Koordinaten des Leuchtturms extrahieren
                    double leuchtturmX = double.Parse(position[0]);
                    double leuchtturmY = double.Parse(position[1]);

                    // Distanz zwischen dem Schiff und dem Leuchtturm berechnen
                    double distanz = Math.Sqrt(Math.Pow(schiffX - leuchtturmX, 2) + Math.Pow(schiffY - leuchtturmY, 2));

                    // Wenn die Distanz kleiner als die Reichweite ist und die Distanz kleiner ist als die bisher kleinste Distanz
                    if (distanz <= reichweite && distanz < kleinsteDistanz)
                    {
                        kleinsteDistanz = distanz;
                        nächsterLeuchtturm = name; // Nächster Leuchtturm gefunden
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Fehler beim Lesen der Datei: " + ex.Message);
        }

        // Wenn kein Leuchtturm gefunden wurde, null zurückgeben
        return nächsterLeuchtturm;
    }

    static void Main(string[] args)
    {
        // Beispielkoordinaten des Schiffs
        double schiffX = 3.0;
        double schiffY = 50.0;

        // Den nächsten sichtbaren Leuchtturm finden
        string leuchtturm = NächsterLeuchtturm(schiffX, schiffY);

        if (leuchtturm != null)
        {
            Console.WriteLine("Der nächstgelegene sichtbare Leuchtturm ist: " + leuchtturm);
        }
        else
        {
            Console.WriteLine("Kein sichtbarer Leuchtturm in der Nähe.");
        }
    }
}
