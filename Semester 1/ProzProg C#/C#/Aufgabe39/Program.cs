static int SatzAnalyse(string[] arr, int jahr, out int anzahlNachrichten)
{
    string path = @"..\..\..\chat.txt";
    int count = 0;
    anzahlNachrichten = 0;
    StreamReader sr = new StreamReader(path);

    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        string[] teile = line.Split(' ');
        string[] datum = teile[0].Split('-');
        if (datum[0] == jahr.ToString())
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool end = false;
                for (int j = 1; j < teile.Length; j++)
                {
                    if (arr[i] == teile[j])
                    {
                        count += teile.Length - 1;
                        end = true;
                        anzahlNachrichten++;
                        break;
                    }
                }
                if (end)
                    break;
            }
        }
    }
    sr.Close();
    return count;
}
