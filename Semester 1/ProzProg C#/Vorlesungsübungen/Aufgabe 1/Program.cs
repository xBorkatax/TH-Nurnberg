namespace Aufgabe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var komo = Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine(komo.Key);
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(komo.Key);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(komo.KeyChar);
            Console.BackgroundColor = ConsoleColor.Black;
            
        }
    }
}
