Console.Write("Basis eingeben: ");
double x = double.Parse(Console.ReadLine());

Console.Write("Exponent eingeben: ");
int n = int.Parse(Console.ReadLine());
for (double i = 0; i <= n; i++)
    {
        
        x *= x ;
        Console.WriteLine(x);
    }
