Console.WriteLine("°C   | °F   ");
Console.WriteLine("-----+------");

for (double i = 0;i <= 100; i += 4)
{
    double fahrenheit = (9 / 5 * i) + 32;
    Console.WriteLine($"  {i:F1} | {fahrenheit:F1}");
}
