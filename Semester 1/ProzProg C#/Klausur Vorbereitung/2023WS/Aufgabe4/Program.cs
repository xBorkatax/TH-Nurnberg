static int[] ClickStatistik(int jahr, params string[] domains)
{
    int[] arr = new int[domains.Length];
    string path = @"..\..\..\server.txt";
    StreamReader sr = new StreamReader(path);
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        string[] teile = line.Split(' ');
        string[] datum = teile[0].Split("-");
        if (datum[0] == jahr.ToString())
        {
            string[] pathLog = teile[2].Split('/');
            if (teile[3] == "200")
            {
                for (int i = 0; i < domains.Length; i++)
                {
                    if (pathLog[0] == domains[i])
                    {
                        arr[i]++;
                    }
                }      
            }
        }
    }
    sr.Close();
    return arr;
    
}
ClickStatistik(2023, "myshop.de", "bestdeal.de");
Console.WriteLine(  );