namespace Aufgabe25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Umgekehrte Zahl: " + Twist(4567));
        }
        static int Twist(int zahl) 
        {
            int twist = 0;

            while (zahl > 0)
            {
                int ziffer = zahl % 10; 
                twist = twist * 10 + ziffer; // 0 * 10 + 7 = 7; 7 * 10 + 6 = 76 ....
                zahl /= 10;
            }

            return twist;
        }
    }
}
