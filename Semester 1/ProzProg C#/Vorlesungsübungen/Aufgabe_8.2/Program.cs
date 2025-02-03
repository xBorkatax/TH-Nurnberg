using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;

namespace Aufgabe_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] m1 = { { 1, 0, 0 },
                          { 0, 1, 0 },
                          { 0, 0, 1 } };
            bool isIdentity = IsIdentity(m1);
            if (isIdentity)
            {
                Console.WriteLine("true");
            }

        }
        static bool IsIdentity(int[,] f)
        {
            int sum = 0;
            foreach (var x in f)
            {
                sum += x;
            }
            if (sum != f.GetLength(1))
            {
                return false;
            }

            for (int i = 1; i < f.GetLength(1); i++)
            {
                if (f[i - 1,i - 1] != f[i, i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
