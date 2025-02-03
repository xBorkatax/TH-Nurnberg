int[] arr = new int[10];

arr = [5, 8, 6, 4, 3, 5, 9, 2, 6, 9];
//SumUndDurchschnitt(arr);
//WeitereZahl(arr);
//MaxUndMinZahl(arr);
int feld = int.Parse(Console.ReadLine());
//int result = Ausgabe(arr, feld);
//Console.WriteLine(result);
FeldStatistic(arr);
static void SumUndDurchschnitt(int[] arr)
{   
    double sum = 0;
    double durchschnitt = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
        durchschnitt = sum / arr.Length;    
    }
    Console.WriteLine(sum);
    Console.WriteLine(durchschnitt);
}

static void WeitereZahl(int[] arr)
{
    Console.Write("Zahl eingeben: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Größer sind: ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (n < arr[i]) 
        {
            Console.Write(arr[i] + " ");
        }
    }
}

static void MaxUndMinZahl(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i]) 
        { 
            max = arr[i];
        }
        if (min > arr[i])
        {
            min = arr[i];
        }
    }
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Minimum: {min}");
}

static int Ausgabe(int[] arr, int feld)
{
    return arr[feld];
}

static void FeldStatistic(int[] arr)
{
    SumUndDurchschnitt(arr);
    MaxUndMinZahl(arr);
}