static int[] Mult(int[,] arrDim, int[] arr)
{
	if (arrDim.GetLength(1) != arr.Length) 
	{
		return null;
	}
	int[] ergenbis = new int[arrDim.GetLength(0)];
	for (int i = 0; i < arrDim.GetLength(0); i++)
	{
		int result = 0;
		for (int j = 0; j < arrDim.GetLength(1); j++)
		{
			result += arrDim[i, j] * arr[j];
		}
		ergenbis[i] = result;
	}
	return ergenbis;
}
int[,] A = { { 1, 2, 0, }, { 3, 0, 2 } };
int[] x = { 1, 2, 3 };
int[]? y = Mult(A, x);