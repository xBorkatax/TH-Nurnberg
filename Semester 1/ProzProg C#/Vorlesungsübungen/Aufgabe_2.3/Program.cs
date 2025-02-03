Console.Write("Geben Sie Ihren Namen an: ");
string name = Console.ReadLine();

Console.Write("(H)err oder (F)rau: ");
string gender = Console.ReadLine().ToUpper();

if (gender == "H")
{
    Console.WriteLine($"Guten Tag, Herr {name}!");
}
else if (gender == "F")
{
    Console.WriteLine($"Guten Tag, Frau {name}!");
}
else
{
    Console.WriteLine("Error");
}