enum FlugTyp { Linie = 1, Charter}
class Flug
{
    private int nr;
    private string start;
    private string ziel;
    private int dauer;
    private FlugTyp typ;
    public void SetDauer(string time)
    {
        if (time.Length < 4)
        {
            throw new ArgumentException("Time must be in format 0:00!");
        }
        string[] teile = time.Split(':');
        int result = int.Parse(teile[0]) * 60 + int.Parse(teile[1]);
        dauer = result;
    }
    public Flug(int nr, string start , string ziel, string dauer, FlugTyp typ = FlugTyp.Linie)
    {
        this.nr = nr;
        this.start = start;
        this.ziel = ziel;
        SetDauer(dauer);
    }
    public string GesamtDauer(Flug[] route)
    {
        string ziel = "";
        int dauer = 0;
        foreach (Flug flug in route)
        {
            if (flug.start != ziel && ziel != "")
            {
                throw new ArgumentException();
            }
            ziel = flug.ziel;
            dauer += flug.dauer;
        }
        int stunde = dauer / 60;
        int minutes = dauer % 60;
        string result = stunde.ToString() + ":" + minutes.ToString();
        return result;
    }
    public override string ToString()
    {
        return $"Flug: {nr} von {start} nach {ziel} dauern {dauer} Stunden.";
    }
}
class Program
{
    static void Main()
    {
        Flug strecke1 = new Flug(312, "Nürnberg", "München", "0:45");
        Flug strecke2 = new Flug(927, "München", "London", "0:15");
        Flug strecke3 = new Flug(4642, "London", "New York", "5:30");
        strecke2.SetDauer(":15");

        Flug[] route = { strecke1, strecke2, strecke3 };
            Console.WriteLine("Gesamtzeit: " + strecke1.GesamtDauer(route));

        Console.WriteLine(strecke2); // strecke2.ToString()
    }
}