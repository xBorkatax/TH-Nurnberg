namespace Aufgabe30
{
    internal class Program
    {
        static bool ContainsExactlyOneSeven(int number)
        {
            int sevenCount = 0;

            while (number > 0)
            {
                int digit = number % 10;

                if (digit == 7)
                {
                    if (sevenCount > 0)
                        return false;
                    sevenCount++;
                }

                number /= 10;
            }

            return sevenCount == 1;
        }

        static void Main(string[] args)
        {
            Console.Write("Въведете число a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Въведете число b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Числата от {a} до {b}, които съдържат точно една цифра '7':");
            for (int num = a; num <= b; num++)
            {
                if (ContainsExactlyOneSeven(num))
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
