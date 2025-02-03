using System.IO;
class VokabelManager
{
    string[] vokPaare = new string[300]; // Speicher für die Vokabelpaare OHNE die Abschnittnamen
    string[] absNamen = new string[10]; // Feld für die Abschnittnamen
    int[] absAnf = new int[10]; // Indexfeld, in dem die Abschnittanfänge in vokPaare gemerkt werden
    int anzVok = 0; // Anzahl der im Vokabelfeld gespeicherten Vokabeln
    int anzAbs = 0; // Anzahl der Vokabelabschnitte
    public void VokabelnLesen(string filePath) 
    {
        int count = 0;

        StreamReader sr = new StreamReader(filePath);
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            if (line[0] == '#')
            {
                string[] teile = line.Split('#');
                absNamen[anzAbs] = teile[1];
                absAnf[anzAbs] = count;
                anzAbs++;
                count--;
            }
            else 
            {
                vokPaare[count] = line;
                anzVok++;
            }
            count++;
        }
        sr.Close();
    }
    public void Suchen(string suchtext)
    {
        for (int i = 0; i < anzVok; i++)
        {
            if (vokPaare[i].Contains(suchtext))
            {
                for (int j = anzAbs - 1; j >= 0; j--) // Започваме от последния раздел
                {
                    // Проверяваме дали текущото Vokabelpaar е в рамките на раздела
                    if (i >= absAnf[j] && (j + 1 < anzAbs ? i < absAnf[j + 1] : true))
                    {
                        Console.WriteLine($"Abschnitt: {absNamen[j]}");
                        break;  // Излизаме от цикъла, защото сме намерили съответния раздел
                    }
                }
                Console.WriteLine(vokPaare[i]);
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Създаваме обект на VokabelManager
        VokabelManager manager = new VokabelManager();
        manager.VokabelnLesen("C:\\Users\\Neychev\\Desktop\\Klausur Vorbereitung C#\\2016WS\\Aufgabe4\\text.txt");

        // Показваме съобщение на потребителя за търсенето
        Console.WriteLine("Моля, въведете текст за търсене:");

        // Въвеждаме търсения текст от конзолата
        string suchtext = Console.ReadLine();

        // Извършваме търсенето с въведения текст
        manager.Suchen(suchtext);
    }
}