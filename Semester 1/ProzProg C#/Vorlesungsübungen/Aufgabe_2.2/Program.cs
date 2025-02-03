// See https://aka.ms/new-console-template for more information
Console.Write("Betrag eingeben: ");
double price = double.Parse(Console.ReadLine());

Console.Write("Vorauszahlung mit 3% Rabatt (ja/nein): ");
string rabattString = Console.ReadLine();

const double mehrwertsteuersatz = 0.19;

Console.WriteLine($"Betrag: {price:F2}");

if (rabattString == "ja")
{
    const double rabattPercentage = 0.03;
    double rabatt = rabattPercentage * price;
    double mwst = (price - rabatt) * mehrwertsteuersatz;

    double finalPrice = price  + mwst - rabatt;


    Console.WriteLine($"Rabatt: -{rabatt:F2}");
    Console.WriteLine($"Mwst. {mwst:F2}");
    Console.WriteLine("---------------------");
    Console.WriteLine($"Gesamt: {Math.Round(finalPrice, 2)}");
}
else {
    double mwst = price * mehrwertsteuersatz;
    double finalPrice = price + mwst;
    Console.WriteLine($"Mwst. {mwst:F2}");
    Console.WriteLine("---------------------");
    Console.WriteLine($"Gesamt: {finalPrice:F2}");
}