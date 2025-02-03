Console.WriteLine("Bitte geben Sie drei Zahlen ein: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

Console.WriteLine("Vor Rotation:");
Console.WriteLine($"a = {a}, b = {b}, c = {c}");

int d = a + c;
c = d - c;
a = b;
b = d - c;

Console.WriteLine("Nach Rotation:");
Console.WriteLine($"a = {a}, b = {b}, c = {c}");