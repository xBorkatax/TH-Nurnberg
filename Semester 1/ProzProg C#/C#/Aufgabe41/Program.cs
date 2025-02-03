int[] Compact(int[] arr)
{
    int[] ergebnis = new int[arr.Length];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0)
        {
            ergebnis[index] = arr[i];
            index++;
        }
    }
    for (int j = index; j < ergebnis.Length; j++)
    {
        if (ergebnis[j] == 0)
        {
            ergebnis[j] = -1; 
        }
    }
    return ergebnis;
}