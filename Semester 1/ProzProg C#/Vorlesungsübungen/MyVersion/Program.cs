namespace Praktikumsaufgabe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Datei-Pfad zum Text
            string filePath = @"..\..\..\kafka_verwandlung.txt";
            string filePathDemo = @"..\..\..\demo.txt";

            // Variablen zur Speicherung der Analyseergebnisse
            int totalCharacters = 0;
            int totalWords = 0;
            int[] alphabetCount = new int[26]; // Häufigkeit der Buchstaben
            int[,] alphabetCombination = new int[26, 26]; // Kombinationen der Buchstaben
            string longestWord = "";
            int longestWordLine = 0;
            int longestWordPosition = 0; // Position des längsten Wortes in der Zeile

            int lineNumber = 0; // Zähler für Zeilen

            StreamWriter srs = new StreamWriter(filePath);
            srs.Close();
            using (StreamReader sr = new StreamReader(filePath)) // Datei lesen
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lineNumber++;
                    string[] words = line.Split(' ');

                    // Schleife über alle Wörter
                    for (int j = 0; j < words.Length; j++)
                    {
                        string word = words[j];
                        if (word.Length > longestWord.Length) // Prüfen auf längstes Wort
                        {
                            longestWord = word;
                            longestWordLine = lineNumber;
                            longestWordPosition = j + 1;
                        }

                        // Schleife über alle Zeichen im Wort
                        for (int k = 0; k < word.Length; k++)
                        {
                            char current = word[k];
                            totalCharacters++;
                            int currentIndex = Index(current); // Index des Buchstabens
                            if (currentIndex != -1)
                            {
                                alphabetCount[currentIndex]++; // Buchstaben zählen

                                // Kombinationen mit dem nächsten Buchstaben prüfen
                                if (k < word.Length - 1)
                                {
                                    char next = word[k + 1];
                                    int nextIndex = Index(next);
                                    if (nextIndex != -1)
                                    {
                                        alphabetCombination[currentIndex, nextIndex]++;
                                    }
                                }
                            }
                        }
                        totalWords++; // Wörter zählen
                        totalCharacters++; // Leerzeichen hinzufügen
                    }
                    totalCharacters--; // Letztes Leerzeichen entfernen
                }
            }


            Console.WriteLine("Der Text enthält:");
            Console.WriteLine($"- {lineNumber} Zeilen");
            Console.WriteLine($"- {totalWords} Wörter");
            Console.WriteLine($"- {totalCharacters} Zeichen");
            Console.WriteLine($"Längstes Wort: \"{longestWord}\" (Zeile {longestWordLine}, Position {longestWordPosition})");


            Console.WriteLine("\nHäufigkeiten der Buchstaben:");
            for (int i = 0; i < 26; i++)
            {
                if (alphabetCount[i] > 0)
                {
                    // Häufigste Kombination für den aktuellen Buchstaben
                    int maxCount = 0;
                    int maxIndex = -1;

                    for (int j = 0; j < 26; j++)
                    {
                        if (alphabetCombination[i, j] > maxCount)
                        {
                            maxCount = alphabetCombination[i, j];
                            maxIndex = j;
                        }
                    }

                    if (maxIndex != -1)
                    {
                        Console.WriteLine($"{(char)(i + 'a')}: {alphabetCount[i],7}; Häufigste Kombination: {(char)(i + 'a')}{(char)(maxIndex + 'a')} ({maxCount}x)");
                    }
                    else
                    {
                        Console.WriteLine($"{(char)(i + 'a')}: {alphabetCount[i]}; Häufigste Kombination: Keine");
                    }
                }
            }
        }

        static int Index(char c)
        {
            // Kleinbuchstaben (ohne Umlaute)
            if (c >= 'a' && c <= 'z')
                return c - 'a';
            // Großbuchstaben (ohne Umlaute)
            else if (c >= 'A' && c <= 'Z')
                return c - 'A';
            // alles andere
            else
                return -1;
        }
    }
}
