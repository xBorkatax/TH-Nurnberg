static bool QuerZahl(int zahl)
{
    int originalZahl = zahl;
    int quersum = 0;
    int querprod = 1;
    while(zahl != 0)
    {
        int rest = zahl % 10;
        querprod *= rest;
        quersum += rest;
        zahl /= 10;
    }
    return (querprod + quersum == originalZahl);
}