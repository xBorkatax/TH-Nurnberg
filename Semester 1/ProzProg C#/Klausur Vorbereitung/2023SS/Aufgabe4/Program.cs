enum Fahrradtyp { MountainBike = 1, EBike, Rennrad, Citybike }
class Fahrrad
{
    private int id;
    private Fahrradtyp typ;
    private int ijahr;
    private double gefahreneKm;
    public void SetKm(double km)
    {
        gefahreneKm = km;
    }
    public double GetKm()
    {
        return gefahreneKm;
    }
    public Fahrrad(int id, int ijahr, double gefahreneKm, Fahrradtyp typ = Fahrradtyp.MountainBike )
    {
        this.id = id;
        this.ijahr = ijahr;
        this.gefahreneKm = gefahreneKm;
        this.typ = typ;
    }
    public static  double Nutzung(Fahrrad[] arr, Fahrradtyp typ)
    {
        double gesamteKm = 0;
        int gesamteJahren = 0;
        foreach (Fahrrad element in arr)
        {
            if (element.typ == typ)
            {
                gesamteKm += element.gefahreneKm;
                gesamteJahren += (2022 - element.ijahr) + 1;
            }
        }
        if (gesamteJahren == 0)
        {
            return 0;
        }
        return gesamteKm / gesamteJahren;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Fahrrad rad1 = new Fahrrad(12, 1999, 123.6);
        Fahrrad rad2 = new Fahrrad(34, 2020, 56.8, Fahrradtyp.EBike);
        Fahrrad rad3 = new Fahrrad(13, 2012, 356.8);
        Fahrrad[] bestand = { rad1, rad2, rad3 };
        foreach (Fahrrad rad in bestand)
        {
            if (rad.GetKm() == 0)
            {
                rad.SetKm(10);
            }
        }
        Console.WriteLine(Fahrrad.Nutzung(bestand, Fahrradtyp.MountainBike));
    }
}