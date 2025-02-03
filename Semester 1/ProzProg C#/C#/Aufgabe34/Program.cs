namespace Aufgabe34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"..\..\..\Speisekarte.txt";
            StreamReader sr = new StreamReader(filePath);
            string line;
            string[] text = new string[];
            int i = 0;
            while ((line = sr.ReadLine()) != null)
            {
                
            }
            Rechnung();
        }
        public static void Rechnung()
        {
            
        }
    }
}