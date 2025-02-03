string path = @"..\..\..\..\Aufgabe_10.1\verkauf.txt";
StreamReader sr = new StreamReader(path);
StreamWriter swas = new StreamWriter(path);
string kopie = @"..\..\..\umsatz.txt";
StreamWriter sw = new StreamWriter(kopie);

int n = 1;
while (!sr.EndOfStream)
{
    string line = sr.ReadLine();
    string[] teil = line.Split(';');
    sw.WriteLine($"{n}. {teil[0]} für {teil[1]} Euro");
    n++;
}
sw.Flush();