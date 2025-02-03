namespace Aufgabe31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = "boris.neychev8@gmail.com";
            if (IsValidEmail(n))
            {

            }
        }
        static bool IsValidEmail(string email)
        {
            bool hasSymbol = false;
            if (email == "" || email == null)
            {
                return false;
            }
            for (int i = 0; i < email.Length; i++)
            {
                if (i > 0 && i < email.Length - 1)
                {
                    if (email[i] == '@')
                    {
                        if (hasSymbol)
                        {
                            return false;
                        }
                        hasSymbol = true;
                    }
                }
                    if (!char.IsDigit(email[i]) && !char.IsLetter(email[i]) && email[i] != '@' && email[i] != '.')
                    {
                        return false;
                    }
                    if (email[i] == '.' && hasSymbol)
                    {
                        return true;
                    }
                
            }
            return false;
        }
    }
}
