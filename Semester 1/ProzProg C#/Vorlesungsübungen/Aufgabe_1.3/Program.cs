namespace Aufgabe_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text1 = "Die Datei finden Sie im Verzeichnis C:\\uebung\\c\\neu\\aufgabe1";
            string text2 = "Es gibt in C# das Hochkomma \"'\" und das Anführungszeichen \"\"\"!";
            string text3 = "\\\\\"\""; /* \\->\ + \->\ + " +\" == \\"" */
            Console.WriteLine(text1);
            Console.WriteLine(text2);
            Console.WriteLine(text3);

        }
    }
}
