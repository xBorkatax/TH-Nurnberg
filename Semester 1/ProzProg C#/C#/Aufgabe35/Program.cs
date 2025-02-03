static int[] MergeSortedArrays(int[] arr1, int[] arr2)
{
    int[] result = new int[arr1.Length + arr2.Length];
    int i = 0;
    int j = 0;

    for (int k = 0; k < result.Length; k++)
    {
        if (i < arr1.Length && (j >= arr2.Length || arr1[i] < arr2[j]))
        {
            result[k] = arr1[i++];
        }
        else
        {
            result[k] = arr2[j++];
        }
    }

    return result;
}

int[] arr1 = { 1, 3, 5, 7, 8, 8,9 };
int[] arr2 = { 2, 4, 6, 8 ,8};
int[] mergedArray = MergeSortedArrays(arr1, arr2);
foreach (int item in mergedArray)
{
    Console.WriteLine(item);
}

