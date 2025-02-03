Console.WriteLine("Beitragsrechnung für einen Verein");
Console.WriteLine("=================================");
Console.Write("Geben Sie Ihr Alter ein: " );
int age = int.Parse(Console.ReadLine());

int payment = 0;
if ( age <= 6)
{
    Console.WriteLine("Ihr Beitrag ist frei.");
}
else if ( age <= 17)
{
    payment = 30;
}
else if ( age <= 65)
{
    Console.Write("Sind Sie erwerblos (j/n): ");
    char jobless = char.Parse(Console.ReadLine());
    if ( jobless == 'j')
    {
        payment = 40;
    }
    else
    {
        payment = 80;
    }
}
else
{
    payment = 50;
}

if ( payment != 0)
{
    Console.WriteLine($"Ihr Beitrag ist {payment} Euro.");
}
