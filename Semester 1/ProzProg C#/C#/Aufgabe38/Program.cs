static int Randsumme(int[,] feld)
{
    int summe = 0;
    int rows = feld.GetLength(0); 
    int cols = feld.GetLength(1); 


    for (int i = 0; i < cols; i++)
    {
        summe += feld[0, i];
    }


    if (rows > 1)
    {
        for (int i = 0; i < cols; i++)
        {
            summe += feld[rows - 1, i];
        }
    }


    for (int i = 1; i < rows - 1; i++)
    {
        summe += feld[i, 0]; 
        summe += feld[i, cols - 1]; 
    }

    return summe;
}