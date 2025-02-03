using System.Diagnostics;

namespace Aufgabe24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Fall 1: Preis = {Bezugspreis(125, 2, 10):0.00} Euro");
            Console.WriteLine($"Fall 2: Preis = {Bezugspreis(200, 1, 3):0.00} Euro");
            Console.WriteLine($"Fall 3: Preis = {Bezugspreis(375, 3, 0):0.00} Euro");
            Console.WriteLine($"Fehler: Preis = {Bezugspreis(50, 4, 0):0.00} Euro");
            Console.WriteLine($"Fehler: Preis = {Bezugspreis(150, 1, -1):0.00} Euro");
        }
        static double Bezugspreis(double listenPreis, int versandArt, double rabatt)
        {
            double sum = listenPreis;
            if (rabatt < 0)
            {
                return -1;
            }
            else if (rabatt > 0)
            {
                rabatt /= 100;
                rabatt *= sum;
                sum -= rabatt;
            }
            switch (versandArt) 
            {
                case 1:
                    return sum + 4.9;
                case 2:
                    return sum + 6.5;
                case 3:
                    return sum + 12;
                default:
                    return sum = -1;
            }
            return sum;
        }
    }
}
