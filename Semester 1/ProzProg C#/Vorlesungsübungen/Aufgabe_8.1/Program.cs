using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        //spalten - kolona zeile - red
        int[,] feld2d = new int[6, 4];
        Random random = new Random();
        for (int i = 0; i < feld2d.GetLength(0); i++)
        {
            for (int j = 0; j < feld2d.GetLength(1); j++)
            {
                feld2d[i, j] = random.Next(0, 10);
            }
        }
        Ausgabe(feld2d);

        Console.WriteLine();
        int[,] f2 = Transponiere(feld2d);
        Console.WriteLine("Transponiert:");
        Ausgabe(f2);
        Console.WriteLine();
        SpaltenSumme(feld2d);
    }
    static void Ausgabe(int[,] f)
    {
        for (int i = 0; i < f.GetLength(0); i++)
        {
            for(int j = 0; j < f.GetLength(1); j++)
            {
                Console.Write($"{f[i,j],3}");
            }
            Console.WriteLine();
        }

        //foreach (int x in f)
        //{ 
        //   Console.WriteLine(x);
        //}

        //int rowCount = f.GetLength(0);
        //int colCount = f.GetLength(1);
        //
        //int index = 0;
        //foreach (var item in f)
        //{
        //   int i = index / colCount;  // Row index
        //    int j = index % colCount;  // Column index
        //    Console.WriteLine($"f[{i},{j}] = {item}");
        //    index++;
        //}
    }
    static int[,] Transponiere(int[,] f)
    {
        int[,] f2 = new int[f.GetLength(1),f.GetLength(0)];
        int col = 0;
        int row = 0;
        for (int i = 0; i < f.GetLength(1); i++)
        {
            for (int n = 0;  n < f.GetLength(0); n++)
            {
                f2[col, row] = f[n,i];
                row++;
                if (row == f.GetLength(0))
                {
                    row = 0;
                    col++;
                }
            }
        }

        //for (int i = 0; i < f.GetLength(0); i++)  
        //{
        //    for (int j = 0; j < f.GetLength(1); j++)  
        //    {
        //        f2[j, i] = f[i, j];  
        //    }
        //}
        return f2;
    }
    static void SpaltenSumme(int[,] f)
    {
        int[] sums = new int[f.GetLength(1)];
        for (int i = 0; i < f.GetLength(1); i++)
        {
            for (int j = 0; j < f.GetLength(0); j++)
            {
                sums[i] += f[j,i];
            }
        }
        Ausgabe(f);
        for (int m = 0; m < sums.Length; m++)
        {
            Console.Write("---");
        }
        Console.WriteLine();
        for (int m = 0; m < sums.Length; m++)
        {
            Console.Write($"{sums[m],3}");
        }
    }
}