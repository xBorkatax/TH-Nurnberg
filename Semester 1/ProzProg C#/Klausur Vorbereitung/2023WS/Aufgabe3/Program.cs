enum Typ { Nord = 1, Ost, Sued, West}
class Roboter
{
    private double x;
    private double y;
    private Typ ausrichtung;

    public Roboter(double x, double y, Typ ausrichtung = Typ.Nord)
    {
        this.x = x;
        this.y = y;
        this.ausrichtung = ausrichtung;
    }
    public Typ GetAusrichtung()
    {
        return ausrichtung;
    }
    public void Drehen(Typ ausrichtung)
    {
        this.ausrichtung = ausrichtung;
    }
    public void GetPosition(out double x, out double y)
    { 
        x = this.x;
        y = this.y;
    }
    public void Bewegung(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Roboter[] schwarm = new Roboter[2]; // gegeben
        double x = 0; 
        double y = 0;
        foreach (Roboter robot in schwarm)
        {
            if (robot.GetAusrichtung() == Typ.Sued)
            {
                robot.Bewegung(x, y);
                robot.Drehen(Typ.Nord);
            }
        }
    }
}
