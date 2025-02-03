string LeuchtturmSuche(double x, double y)
{
    double kleinsteDistanz = double.MaxValue;
    string leuchtTurm = null;
    string path = @"..\..\..\lights.txt";
    StreamReader sr = new StreamReader(path);
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        string[] teile = line.Split('|');
        string[] position = teile[2].Split(";");
        double turmX = double.Parse(position[0]);
        double turmY = double.Parse(position[1]);
        double distanz = Math.Sqrt((x - turmX) * (x - turmX) + (y - turmY) * (y - turmY));
        if (double.Parse(teile[3]) > distanz && kleinsteDistanz > distanz)
        {
            kleinsteDistanz = distanz;
            leuchtTurm = teile[1];
        }
    }
    sr.Close();
    return leuchtTurm;
}