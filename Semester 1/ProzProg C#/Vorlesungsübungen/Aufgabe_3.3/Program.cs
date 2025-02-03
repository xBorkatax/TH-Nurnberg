/*Console.Write("Zahl eingeben: ");
int number = int.Parse(Console.ReadLine());
Console.Write($"Quadratzahlen bis max. {number}: ");
for (int i = 1; i < number; i++)
{
    int a = i * i;
    if (a < number)
    {
        i++;
        int e = i * i;
        if (e < number)
        {
            Console.Write(a + ", ");
        }
        else
        {
            Console.WriteLine(a);
        }
        i--;
    }
}
*/

/*
List<int> b = new List<int>();

for (int i = 1; i * i < number; i++)
{
    b.Add(i * i);
}

Console.Write($"Quadratzahlen bis max. {number}: ");
Console.Write(string.Join(", ", b));
*/

Console.Write("Zahl eingeben: ");
int number = int.Parse(Console.ReadLine());
Console.Write($"Quadratzahlen bis max. {number}: ");
bool first = true; 
for (int i = 1; i * i < number; i++)
{
    int square = i * i;
    if (!first)
    {
        Console.Write(", ");
    }
    Console.Write(square);
    first = false;
}