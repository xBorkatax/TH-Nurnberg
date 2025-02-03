namespace Aufgabe33
{
    class Person
    {
        private int persnr;
        private string vorname;
        private string nachname;
        private string email;

        public Person(int persnr, string vorname, string nachname, string email)
        {
            this.persnr = persnr;
            if (vorname.Length >= 2 && nachname.Length >= 2)
            {
                this.vorname = vorname;
                this.nachname = nachname;
            }
            else
            {
                throw new Exception("Vorname and Nachname must be at least 2 characters long.");
            }
            this.email = email;
        }
        public string GetName()
        {
            return $"{vorname}, {nachname}";
        }
        public string GetEmail() 
        { 
            return email ; 
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public override string ToString()
        {
            return $"Person: {persnr}, Name: {vorname} {nachname}, Email: {email}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(12,"Anne", "Meier", "ameier@thn.de");
            Console.WriteLine(person.GetName());
            Console.WriteLine(person);
            person.SetEmail("ameier@th-nuernberg.de");
            Console.WriteLine(person);
        }
    }
}
