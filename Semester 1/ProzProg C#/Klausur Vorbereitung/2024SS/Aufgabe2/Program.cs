static void Sort(int[] arr)
{
	for (int i = 0; i < arr.Length - 1; i++)
	{
		int aktuelle = arr[i];
		for (int j = i + 1; j < arr.Length; j++)
		{
			if (arr[j] < arr[i])
			{
				arr[i] = arr[j];
				arr[j] = aktuelle;
			}
		}
	}
}
int[] arr = { 3, 1, 4, 2 };
Sort(arr);