enum Antriebe { Segel = 1, Motor, Runder}
class Schiff
{
    private string name;
    private double laenge;
    private Antriebe antrieb;
    public Schiff(string name, double laenge, Antriebe antrieb = Antriebe.Segel)
    {
        this.name = name;
        this.laenge = laenge;
        this.antrieb = antrieb;
    }

    public double Laenge
    {
        get { return laenge; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Laenge), "Die Länge muss größer als 0 sein.");
            }
            laenge = value;
        }
    }
    public double VRumpf()
    {
        return 2.43 * Math.Sqrt(laenge);
    }
    public static double Mittel(Schiff[] schiffs, Antriebe antriebe)
    {
        double summe = 0;
        int count = 0;

        foreach (var schiff in schiffs)
        {
            if (schiff.antrieb == antriebe) 
            {
                summe += schiff.Laenge;
                count++;
            }
        }

        if (count == 0)
        {
            return 0;
        }

        return summe / count;
    }
}
class Program
{
    static void Main()
    {
        Schiff schiff1 = new Schiff("Victoria", 30.5, Antriebe.Motor);
        Console.WriteLine(schiff1.Laenge);

        Schiff[] schiffe = new Schiff[]
        {
            new Schiff("Victoria", 30, Antriebe.Motor),
            new Schiff("Berlin", 50, Antriebe.Segel),
            new Schiff("Hamburg", 40, Antriebe.Motor),
            new Schiff("Köln", 20, Antriebe.Segel)
        };

        // Извикване на метода Mittel с масива schiffe и антиправа система Segel
        double durchschnitt = Schiff.Mittel(schiffe, Antriebe.Segel);

        // Извеждане на резултата
        Console.WriteLine($"Durchschnittliche Länge der Schiffe mit Segel: {durchschnitt} Meter");
    }
}