static double MatrixSumme(double[,] matrix)
{
    double sum = 0;
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		sum += matrix[i, matrix.GetLength(0) - i - 1];
	}
	return sum;
}