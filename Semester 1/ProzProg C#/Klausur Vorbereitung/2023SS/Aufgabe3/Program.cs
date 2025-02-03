static double[] Gewinn(string artikel, int jahr)
{
    double[] monate = new double[13];
    string path = @"..\..\..\verkauf.txt";
    StreamReader sr = new StreamReader(path);
    string topLine = sr.ReadLine();
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        string[] teile = line.Split(' ');
        string[] datum = teile[0].Split(".");
        if (datum[2] == jahr.ToString() && teile[1] == artikel)
        {
            int indexForMonat = int.Parse(datum[1]);
            double gewinn = (double.Parse(teile[3]) - double.Parse(teile[2])) * int.Parse(teile[4]);
            monate[indexForMonat] = gewinn;
        }
    }
    sr.Close();
    return monate;
}