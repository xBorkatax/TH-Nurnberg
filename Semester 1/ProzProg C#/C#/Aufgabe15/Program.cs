namespace Aufgabe15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            char c;
            do
            {
                Console.Write("Enter a character: ");
                c = char.Parse(Console.ReadLine());
            }
            while (c != '+' || c != '-' || c != '*' || c != '/' );


            double sum = 0;
            switch (c)
            {
                case '+':
                   sum =  a + b;
                    break;
                case '-':
                    sum = a - b;
                    break;
                case '*':
                    sum = a * b;
                    break;
                case '/':
                    sum = a / b;
                    break;
            }
            Console.WriteLine(sum);
        }
    }
}
