using System;
enum Typ { Bekleidung = 1, Haushalt, Einrichtung, Sonstiges };
class Artikel
{
    private int artNr;
    private string artName;
    private double artPreis;
    private Typ artTyp;
    
    public Artikel(int artNr, string artName, double artPreis, Typ artTyp = Typ.Sonstiges)
    {
        this.artNr = artNr;
        this.artName = artName;
        this.artPreis = artPreis;
        this.artTyp = artTyp;
    }
    public void SetPreis(double preis)
    {
        artPreis = preis;
    }
    public double GetPreis()
    {
        return artPreis;
    }
    public Typ GetType()
    {
        return artTyp;
    }
    public static string Teuerster(Artikel[] arr, out double artPreis)
    {
        artPreis = 0;
        string name = null;
        foreach (var item in arr)
        {
            if (item.artPreis > artPreis)
            {
                artPreis = item.artPreis;
                name = item.artName;
            }
        }
        return name;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Artikel art1 = new(12, "Jeanshose", 89.60, Typ.Bekleidung);
        Artikel art2 = new(3, "Tasse", 23.89, Typ.Haushalt);
        Artikel art3 = new(42, "Schokoriegel", 2.90);
        Artikel[] artikel = { art1, art2, art3 };
        foreach (var item in artikel)
        {
            item.SetPreis(item.GetPreis() * 1.10);
        }
        Console.WriteLine($"{Artikel.Teuerster(artikel, out double preis)} {preis}");
        // Ausgabe (f)
        // Jeanshose 98,56
    }
}
