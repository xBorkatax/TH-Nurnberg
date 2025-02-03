namespace Aufgabe28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StartsWith:");
            Console.WriteLine(StartsWith("Hallo", "Hal"));
            Console.WriteLine(StartsWith("Hallo", "Halt"));
            Console.WriteLine(StartsWith("Hallo", "Holla"));
            Console.WriteLine();

            Console.WriteLine("Contains:");
            Console.WriteLine(Contains("Guten Tag", "Tag"));
            Console.WriteLine(Contains("Guten Tag", "en"));
            Console.WriteLine(Contains("Guten Tag", "ende"));
            Console.WriteLine(Contains("Guten Tag", "utan"));
            Console.WriteLine(Contains("Guten Tag", "Guten Morgen"));

        }
        static bool Contains(string s1, string s2)
        {
            bool contains = false;
            if (s1.Length < s2.Length)
            {
                return false;
            }
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[0])
                {
                    for (int n = 0; n < s2.Length; n++)
                    {
                        if (s1[i + n] != s2[n])
                        {
                            contains = false;
                            break;
                        }
                        contains = true;
                    }
                }
            }
            if (contains)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool StartsWith(string s1, string s2)
        {
            if (s1.Length < s2.Length)
            {
                return false;
            }
            for (int i = 0; i < s2.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
