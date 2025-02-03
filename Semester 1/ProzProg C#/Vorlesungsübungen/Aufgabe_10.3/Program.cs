string path = @"..\..\..\..\Aufgabe_10.1\verkauf.txt";
StreamReader sr = new StreamReader(path);
string kopie = @"..\..\..\umsatz.txt";
StreamWriter sw = new StreamWriter(kopie);

string line;
string[] teil = null;

if (!sr.EndOfStream)
{
    line = sr.ReadLine();
    teil = line.Split(';');
}

while (!sr.EndOfStream)
{
    string nextLine = sr.ReadLine();
    string[] nextTeil = nextLine.Split(';');
    double sum = Convert.ToDouble(teil[1]);

    if (nextTeil[0] == teil[0])
    {
        double zahl = Convert.ToDouble(nextTeil[1]);
        sum += zahl;
        teil = [teil[0], sum.ToString(),];
    }
    else
    {
        Console.WriteLine($"{teil[0]} für {sum} Euro");
        sw.WriteLine($"{teil[0]} für {sum} Euro");
        teil = nextTeil;
    }
    
}
if (teil != null)
{
    Console.WriteLine($"{teil[0]} für {teil[1]} Euro");
    sw.WriteLine($"{teil[0]};{teil[1]}");
}
sw.Close();
sr.Close();

