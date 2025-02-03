Console.Write("Anzahl Sekunden eingeben: ");
int time = int.Parse(Console.ReadLine());

int hours = time / 3600;
int minutes = (time % 3600) / 60;
int seconds = time % 60;

Console.WriteLine($"Das sind {hours}:{minutes}:{seconds} Stunden.");