static int[,] Transponieren(int[,] f)
{
    int[,] f2 = new int[f.GetLength(1),f.GetLength(0)];
    for(int i = 0; i < f.GetLength(0); i++)
    {
        for (int j = 0; j < f.GetLength(1); j++)
        {
            f2[j, i] = f[i, j];
        }
    }
    return f2;
}
int[,] f = { { 0, 1, 2, 3 }, { 4, 5, 6, 7 } };
int[,] f2 = Transponieren(f);

for (int i = 0; i < f2.GetLength(0); i++)
{
    for (int j = 0; j < f2.GetLength(1); j++)
    {
        Console.Write(f2[i,j]);
    }
    Console.WriteLine();
}