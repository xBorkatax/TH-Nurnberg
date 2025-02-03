namespace Aufgabe_7._5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(QuerSumme(3521)); 
    }
    static int QuerSumme(int n)
    {
        if (n == 0)
            return 0;
        return (n % 10) + QuerSumme(n / 10); 
    }
}