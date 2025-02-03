class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int rowToDelete = 1;

        try
        {
            int[,] result = ZeileLöschen(matrix, rowToDelete);

            PrintMatrix(result);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Грешка: " + ex.Message);
        }
    }

    static int[,] ZeileLöschen(int[,] m, int znr)
    {
        int rows = m.GetLength(0);  
        int cols = m.GetLength(1);  

        if (znr < 0 || znr >= rows)
        {
            throw new ArgumentOutOfRangeException(nameof(znr), "Редицата е извън допустимите граници.");
        }


        int[,] result = new int[rows - 1, cols];

 
        int resultRow = 0;
        for (int i = 0; i < rows; i++)
        {
            if (i == znr) continue;  

            for (int j = 0; j < cols; j++)
            {
                result[resultRow, j] = m[i, j];
            }
            resultRow++;
        }

        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
