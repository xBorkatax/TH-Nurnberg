using System.Runtime.InteropServices;

namespace Aufgabe_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] f = { 6, 7, 4, 3, 2, 5, 9 };
            Console.WriteLine("Feld vorher: ");
            Ausgabe(f);

            Reverse(ref f);
            Console.WriteLine("Feld umgekehrt: ");
            Ausgabe(f);
        }

        static void Ausgabe(int[] f)
        {
            for (int i = 0; i < f.Length; i++)
            {
                Console.WriteLine(f[i]);
            }
        }

        static void Reverse(ref int[] f)
        {
            //f.Reverse();
            for (int i = 0; i < f.Length / 2; i++)
            {
                int a = f[i];
                int b = f[f.Length - 1 - i];
                f[i] = b;
                f[f.Length - 1 - i] = a;   
            }
        }
    }
}
