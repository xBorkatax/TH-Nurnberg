namespace Aufgabe8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello, Welt!";
            Console.WriteLine(ZeichenAnzahl(s));
        }

        static int ZeichenAnzahl(string s)
        {
            int anzahl = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '!' && s[i] != ' ')
                {
                    anzahl++;
                }
            }
            return anzahl;
        }

    }
}
