static void ReverseArray(int[] arr)
{
    for(int i = 0; i < arr.Length/2; i++)
    {
        int element = arr[i];
        arr[i] = arr[(arr.Length - 1) - i];
        arr[(arr.Length - 1) - i] = element;
    }
}
static void PrintArray(int[] arr)
{
    string x = "";
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"{x}{arr[i]}");
        x += "X";
    }
}
    int[] numbers = { 1, 2, 3, 4, 5 };
    ReverseArray(numbers);
    PrintArray(numbers);