namespace Aufgabe_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] f = { 7, 10, 15, 20 };
            BalkenDiagramm(f);
        }
        static void BalkenDiagramm(int[] f)
        {
            for (int i = 0; i < f.Length; i++)
            {
                Console.Write($"{f[i],3} " );
                for (int j = 0; j < f[i]; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
