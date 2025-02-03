string path = @"..\..\..\verkauf.txt";
StreamReader sr = new StreamReader(path);

int n = 1;
while (!sr.EndOfStream)
{
    string line = sr.ReadLine();
    string[] teil = line.Split(';');
    Console.WriteLine($"{n}. {teil[0]} für {teil[1]} Euro");
    n++;
}
