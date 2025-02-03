double Satzanalyse(string[] arr, int jahr, out int zeile)
{
    int wordCount = 0;
    zeile = 0;
    string path = "chat.txt";
    StreamReader sr = new StreamReader(path);

    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        string[] nachrichtTeile = line.Split(' ');
        string[] jahrPruf = nachrichtTeile[0].Split('-');

        if (jahrPruf[0] != jahr.ToString())
        {
            break;
        }
        foreach (string teil in arr)
        {
            bool validate = false;
            for (int i = 1; i < nachrichtTeile.Length; i++)
            {
                if (teil == nachrichtTeile[i])
                {
                    zeile++;
                    wordCount += nachrichtTeile.Length - 1;
                    validate = true;
                    break;
                }
                
            }
            if (validate)
            {
                break;
            }
        }
    }
    sr.Close();
    return 0;
}