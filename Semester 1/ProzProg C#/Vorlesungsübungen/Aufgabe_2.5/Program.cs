Console.WriteLine("Umrechnung meilen in km und ungekehrt");
Console.WriteLine("=====================================");
Console.WriteLine("1) Meilen in km");
Console.WriteLine("1) km in Meilen");
Console.Write("Wählen Sie: ");
int wahl = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.Write("Geben Sie die Entfernung in km ein: ");
double abstand = double.Parse(Console.ReadLine());
Console.WriteLine("");

const double meil = 1.609344;

if (wahl == 1)
{
    double result = abstand * meil;
    Console.WriteLine($"{abstand} Meilen entsprechen {Math.Round(result, 2)} km.");
}
else if (wahl == 2)
{
    double result = abstand / meil;
    Console.WriteLine($"{abstand} km entsprechen {Math.Round(result, 2)} Meilen.");
}
else
{
    Console.WriteLine("error");
}