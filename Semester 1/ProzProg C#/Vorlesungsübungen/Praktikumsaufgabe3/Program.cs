Start(out int zeilen, out int spalten, out int[][] field);
int countForPlayer = 0;
Play(field, ref countForPlayer);

static void Start(out int zeilen, out int spalten, out int[][] field)
{
    zeilen = 0;
    spalten = 0;

    Console.WriteLine("TicTacToe");
    Console.WriteLine("========= \n");
    bool isCorrect = false;
    do
    {
        Console.Write("Zeilen eingeben: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Spalten eingeben: ");
        int m = int.Parse(Console.ReadLine());

        Console.Clear();
        if (n < 3 || m < 3)
        {
            Console.WriteLine("The Field is incorrect \n");
        }
        else
        {
            Console.WriteLine("TicTacToe");
            Console.WriteLine("========= \n");
            Console.WriteLine($"Zeilen eingeben: {n}");
            Console.WriteLine($"Spalten eingeben: {m}");
            isCorrect = true;
            zeilen = n;
            spalten = m;
        }
    }
    while (!isCorrect);
    FieldCreate(zeilen, spalten, out int[][] feld);
    field = feld;
}
static void FieldCreate(int zeilen, int spalten, out int[][] field)
{
    field = new int[zeilen][];
    for (int i = 0; i < zeilen; i++)
    {
        field[i] = new int[spalten];
    }
}
static void Play(int[][] field, ref int countForPlayer)
{
    countForPlayer++;
    PrintField(field, countForPlayer);
    PlayerTurn(countForPlayer, field);
    int playerSymbol = countForPlayer % 2 == 0 ? 2 : 1;
    if (CheckWinner(field, playerSymbol))
    {
        PrintField(field, countForPlayer);
        Console.WriteLine($"\n Player {playerSymbol} wins!");
        return;
    }
    if (countForPlayer == field.Length * field[0].Length)
    {
        PrintField(field, countForPlayer);
        Console.WriteLine($"\n Unentschieden!");
        return;
    }
    Play(field, ref countForPlayer);
}
static void PrintField(int[][] field, int countForPlayer)
{
    if (countForPlayer != 1)
    {
        Console.WriteLine("TicTacToe");
        Console.WriteLine("=========");
    }
    Console.WriteLine();
    for (int i = 0; i < field.Length; i++)
    {
        if (i == 0)
        {
            for (int j = 0; j <= field[i].Length; j++)
            {
                if (j == 0)
                {
                    Console.Write("   ");
                }
                else
                {
                    Console.Write("| " + j + " ");
                }
            }
            Console.WriteLine();
            for (int j = 0; j <= field[i].Length; j++)
            {
                if (j == 0)
                {
                    Console.Write("---");
                }
                else
                {
                    Console.Write("+---");
                }
            }
            Console.WriteLine();
        }

        for (int j = 0; j < field[i].Length; j++)
        {

            if (j == 0)
            {
                Console.Write($"{i + 1,2} ");
            }
            if (field[i][j] == 0)
            {
                Console.Write("|   ");
            }
            if (field[i][j] == 1)
            {
                Console.Write("| X ");
            }
            if (field[i][j] == 2)
            {
                Console.Write("| O ");
            }
        }

        Console.WriteLine();
    }
}
static void PlayerTurn(int countForPlayer, int[][] field)
{
    Console.WriteLine();
    int playerSymbol = 0;
    if (countForPlayer % 2 != 0)
    {
        Console.Write($"{countForPlayer}. Zug, Spieler 1: ");
        playerSymbol = 1;
    }
    else
    {
        Console.Write($"{countForPlayer}. Zug, Spieler 2: ");
        playerSymbol = 2;
    }

    string position = Console.ReadLine();
    if (!position.Contains("-"))
    {
        Console.WriteLine("Valid data must contain \"-\", try again.");
        PlayerTurn(countForPlayer, field);
    }

    string[] parts = position.Split('-');

    if (parts.Length != 2 || !int.TryParse(parts[0], out _) || !int.TryParse(parts[1], out _))
    {
        Console.WriteLine("Valid data must contain 2 numbers separated by \"-\", try again.");
        PlayerTurn(countForPlayer, field);
    }

    int col = int.Parse(parts[0]) - 1;
    int row = int.Parse(parts[1]) - 1;


    if (row < 0 || row >= field.Length || col < 0 || col >= field[row].Length)
    {
        Console.WriteLine("Valid data must be within the field, try again.");
        PlayerTurn(countForPlayer, field);
    }

    if (field[row][col] != 0)
    {
        Console.WriteLine("Position already occupied, try again.");
        PlayerTurn(countForPlayer, field);
    }
    else
    {
        field[row][col] = playerSymbol;
        Console.Clear();
    }
}
static bool CheckWinner(int[][] field, int playerSymbol)
{
    for (int i = 0; i < field.Length; i++)
    {
        for (int n = 0; n < field[i].Length - 2; n++)
        {
            if (field[i][n] == playerSymbol && field[i][n + 1] == playerSymbol && field[i][n + 2] == playerSymbol)
            {
                return true;
            }
        }

    }
    for (int i = 0; i < field.Length - 2; i++)
    {
        for (int n = 0; n < field[i].Length; n++)
        {
            if (field[i][n] == playerSymbol && field[i + 1][n] == playerSymbol && field[i + 2][n] == playerSymbol)
            {
                return true;
            }
        }

    }
    for (int i = 0; i < field.Length - 2; i++)
    {
        for (int n = 0; n < field[i].Length - 2; n++)
        {
            if (field[i][n] == playerSymbol && field[i + 1][n + 1] == playerSymbol && field[i + 2][n + 2] == playerSymbol)
            {
                return true;
            }
        }

    }
    for (int i = 2; i < field.Length; i++)
    {
        for (int n = 2; n < field[i].Length; n++)
        {
            if (field[i][n] == playerSymbol && field[i - 1][n - 1] == playerSymbol && field[i - 2][n - 2] == playerSymbol)
            {
                return true;
            }
        }
    }
    return false;
}
