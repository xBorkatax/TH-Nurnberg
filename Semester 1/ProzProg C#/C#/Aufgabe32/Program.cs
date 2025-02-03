namespace Aufgabe32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Teilmenge([8, 6, 1, 7, 4, 9], [1, 6, 9]));
            Console.WriteLine(Teilmenge1([8, 6, 1, 7, 4, 9, 6], [1, 6, 9, 6, 6]));
            Console.WriteLine(Teilmenge2([8, 6, 1, 7, 4, 9, 6], [1, 6, 9]));
        }
        static bool Teilmenge(int[] a, int[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                bool contain = false;
                for (int j = 0; j < a.Length; j++)
                {
                    
                    if (b[i] == a[j])
                    {
                        if (contain)
                        {
                            return false;
                        }
                        contain = true;
                    }
                }
                if (i == b.Length - 1)
                {
                    return contain;
                }
            }
            return false;
        }
        static bool Teilmenge1(int[] a, int[] b, out int name)
        {
            for (int i = 0; i < b.Length; i++)
            {
                bool contain = false;
                for (int j = 0; j < a.Length; j++)
                {
                    if (b[i] == a[j])
                    {
                        contain = true;
                        break;  
                    }
                }
                if (!contain)  
                {
                    return false;
                }
            }
            return true; 
        }
        static bool Teilmenge2(int[] a, int[] b) 
        {
            for (int i = 0; i < b.Length; i++)  
            {
                bool gefunden = false;


                for (int j = 0; j < a.Length && !gefunden; j++)
                    if (b[i] == a[j])
                        gefunden = true;   

                if (!gefunden)
                    return false;  
            }
            return true;   
        }

    }
}
