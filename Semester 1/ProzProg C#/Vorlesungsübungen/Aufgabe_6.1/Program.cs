Console.Write("Zahl eingeben: ");
int zahl = int.Parse(Console.ReadLine());
Console.Write("Ziffer eingeben: ");
int ziffer = int.Parse(Console.ReadLine());

if (EnthaeltZiffer(zahl, ziffer))
{
    Console.WriteLine($"{zahl} enthalt die {ziffer}");
}
else
{
    Console.WriteLine($"{zahl} enthalt keine {ziffer}");
}

bool EnthaeltZiffer(int zahl, int ziffer)
{
    if (zahl == 0 && ziffer == 0)
    {
        return true;
    }
    while (zahl > 0)
    {
        int sum = zahl;
        if (sum % 10 == ziffer)
        {
        return true;
        }
        sum /= 10;
    }
    return false;
}