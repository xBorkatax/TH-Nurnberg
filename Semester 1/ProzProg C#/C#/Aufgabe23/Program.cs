namespace Aufgabe23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int zahl = 59;
            for (int n = 0;n < 1000 ;n++ ) 
            {
                int querproduckt = Querproduckt(n);
                int quersumme = Quersumme(n);

                if (IstQuerzahl(n))
                {
                    int sum = querproduckt + quersumme;
                    Console.WriteLine($"{n} ist die Summe aus Quersumme und Querprodukt {sum}");
                }
            }
            //int querproduckt = Querproduckt(zahl);
            //Console.WriteLine("Querprodukt " + querproduckt);

            //int quersumme = Quersumme(zahl);
            //Console.WriteLine("Quersumme " + quersumme);

            //if (IstQuerzahl(zahl))
            //{
            //    int sum = querproduckt + quersumme;
            //    Console.WriteLine($"{zahl} ist die Summe aus Quersumme und Querprodukt {sum}");
            //}
        }
        static int Quersumme(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        static int Querproduckt(int n)
        {
            int sum = 1;
            while (n > 0)
            {
                sum *= n % 10;
                n /= 10;
            }
            return sum;
        }
        static bool IstQuerzahl(int n) 
        { 
            int quersumme = Quersumme(n);
            int querproduck = Querproduckt(n);
            if (querproduck + quersumme == n) 
                return true;
            return false;
        }
    }
    
}
