static double Durchschnitt(int[] arr)
{
    double sum = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		sum += arr[i];
	}
	sum /= arr.Length;
	return sum;
}
int[] arr = new int[] {-4,12,35,54643,-123};
Console.WriteLine(Durchschnitt(arr));