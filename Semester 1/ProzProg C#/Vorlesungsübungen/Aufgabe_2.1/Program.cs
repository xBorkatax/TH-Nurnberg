Console.Write("Höhe des Körpers (in Meter): ");
double h = double.Parse(Console.ReadLine());

if (h < 0)
{
    Console.WriteLine("Ungültige Höhe");
}
else
{
    const double g = 9.80665;

    double t = Math.Sqrt(2 * h/g);

    Console.WriteLine($"Fallzeit: {t:F2}");
} 
