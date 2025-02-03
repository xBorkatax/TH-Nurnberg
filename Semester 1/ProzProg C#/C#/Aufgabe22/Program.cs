namespace Aufgabe22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Basis eingeben: ");
            int basis = int.Parse(Console.ReadLine());

            Console.Write("Exponent eingeben: ");
            double exponent = double.Parse(Console.ReadLine());

            double result = Potenz(exponent, basis);
        }
        static double Potenz(double exponent, int basis)
        {
            double result = 1; 
            for (int i = 0; i < exponent; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"{basis}^{i}: 1");
                }
                result *= basis;
                Console.WriteLine($"{basis}^{i}: {result}");
            }
            return result;
        }
    }
}
