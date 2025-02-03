//static int BinarySearch(int[] arr, int target)
//{
//    int links = 0;
//    int rechts = arr.Length - 1;
//    int mitte = arr.Length / 2;
//    while (links != rechts)
//    {
//        if (arr[mitte] == target)
//        {
//            return mitte;
//        }
//        if (arr[mitte] > target)
//        {
//            rechts = mitte;
//            mitte = rechts / 2;
//        }
//        if (arr[mitte] < target)
//        {
//            links = mitte;
//            mitte = mitte + (rechts - mitte) / 2;
//        }
//    }
//    return -1;
//}
static int BinarySearch(int[] array, int target)
{
    int left = 0; 
    int right = array.Length - 1; 

    while (left <= right)
    {
        int mid = left + (right - left) / 2; 

        if (array[mid] == target)
        {
            return mid; 
        }
        else if (array[mid] < target)
        {
            left = mid + 1; 
        }
        else
        {
            right = mid - 1; 
        }
    }

    return -1; 
}

//sortiertes Array
int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
//gesuchte Zahl
int target = 21;
int result = BinarySearch(numbers, target);
if (result != -1)
    Console.WriteLine($"Element gefunden am Index: {result}");
else
    Console.WriteLine($"Element nicht gefunden.");