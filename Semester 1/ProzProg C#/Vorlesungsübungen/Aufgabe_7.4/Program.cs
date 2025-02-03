namespace Aufgabe_7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = {5, 8, 3, 2, 9, 8};

            Sort(a);
            
        }
        static void Sort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {   
                    int falsheZahl = a[i];
                    if (a[j] < a[i])
                    {
                        a[i] = a[j];
                        a[j] = falsheZahl;
                    }
                }
            }
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
        }
    }
}
