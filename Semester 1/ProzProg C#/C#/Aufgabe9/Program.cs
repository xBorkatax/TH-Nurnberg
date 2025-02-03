namespace Aufgabe9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            Func1(num);
            Console.Write(num + ", ");

            Func2(ref num);
            Console.Write(num + ", ");
        }
        static void Func1(int num) 
        {
            num += 10;
            Console.Write(num + ", ");
        }
        static void Func2(ref int num)
        {
            num += 10;
            Console.Write(num + ", ");
        }
    }
}
