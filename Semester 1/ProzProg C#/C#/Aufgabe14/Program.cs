namespace Aufgabe14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            int x, sum = 0;
            for (; ; )
            {
                s = Console.ReadLine();
                x = Convert.ToInt32(s);
                if (x < 0) break;
                sum = sum + x;
                Console.WriteLine(sum);
            }
            Console.WriteLine("End " + sum);
        }
    }
}
