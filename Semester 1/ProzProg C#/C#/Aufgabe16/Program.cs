namespace Ауфгабе16
{
    internal class Program
    {
            static int f(ref int a)
            {
                Console.WriteLine("a (Orginal) = " + a);
                a = 5;
                Console.WriteLine("a (nach Zuweisung) = " + a);
                return a;
            }
            static void Main()
            {
                int x = 1;
                int result = f(ref x);
                Console.WriteLine("x (nach f()) = " + x);
                Console.WriteLine("x (nach f()) = " + result);
            }
    }
}
