static string Funktion(string zahl1, string zahl2)
{
    int max = zahl1.Length;
    if (zahl2.Length > max)
        max = zahl2.Length;
    int m = 0;
    string erg = "";
    for (int i = max - 1; i >= 0; i--)
    {
        int z1 = zahl1[i] - '0';
        int z2 = zahl2[i] - '0';
        int s = z1 + z2 + m;
        m = s / 10;
        s %= 10;
        erg = (char)(s + '0') + erg;
    }
    if (m > 0)
        erg = (char)(m + '0') + erg;
    return erg;
}
Console.WriteLine(Funktion("1234", "5678")); 