Console.WriteLine("Vytajte v kalkulacke");
Console.WriteLine("zadajte prve cislo ");
string s = Console.ReadLine();
float a = int.Parse(s);
Console.WriteLine("zadajte druhe cislo");
string c = Console.ReadLine();
float b = int.Parse(c);

float sucin, sucet, rozdiel, podiel;

sucet = a * b;
Console.WriteLine("sucet: " + sucet);

sucin = a + b;
Console.WriteLine("sucin: " + sucin);

rozdiel = a - b;
Console.WriteLine("rozdiel: " + rozdiel);

podiel = a / b;
Console.WriteLine("podiel: " + podiel);
Console.ReadKey();