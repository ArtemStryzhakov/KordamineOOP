using KordamineOOP;
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");
Koer koer = new Koer(Koer.toug.Mops, "Šarik", "punane", Koduloom.sugu.isane, 35.5, 7);
koer.print_Info();
koer.print_Haal();
Koer veelkoer = new Koer(koer);
veelkoer.muudaNimi("Mopsjara");
veelkoer.muudaVarv("valge");
veelkoer.muudaSugu(Koduloom.sugu.isane);
veelkoer.muudaKaal(7.2);
veelkoer.muudaVanus(3);
veelkoer.print_Info();
Console.WriteLine("----------------------------------------------------------------------------");
//Raccoon
Raccoon raccoonMaksim = new Raccoon(Raccoon.tougR.Eastern_raccoon, "Maksim", "black", Koduloom.sugu.isane, 10, 4, "8/10");
Raccoon raccoonLjoha = new Raccoon(Raccoon.tougR.Florida_raccoon, "Ljoha", "gray", Koduloom.sugu.isane, 15, 5, "10/10");
Raccoon raccoonAndrei = new Raccoon(Raccoon.tougR.Texas_raccoon, "Andrei", "black", Koduloom.sugu.isane, 13, 3, "5/10");
raccoonMaksim.print_Info();
raccoonMaksim.print_Haal();
Console.WriteLine(raccoonMaksim.print_Info());

List<Koduloom> raccoonList = new List<Koduloom>();
raccoonList.Add(raccoonMaksim);
raccoonList.Add(raccoonLjoha);
raccoonList.Add(raccoonAndrei);

using (StreamWriter writer = new StreamWriter("C:\\Users\\opilane\\source\\repos\\Artem Stryzhakov TARpv20\\raccoon.txt"))
{
	foreach (Koduloom x in raccoonList)
	{
        writer.WriteLine(x.nimi + "," + x.nahaalsus + ",");
    }
}
Console.WriteLine("\n");
List<Raccoon> tootajad = new List<Raccoon>();
StreamReader sr = new StreamReader("C:\\Users\\opilane\\source\\repos\\Artem Stryzhakov TARpv20\\raccoon.txt");
string text;
while ((text = sr.ReadLine()) != null)
{
    string[] rida = text.Split(',');
    tootajad.Add(new Raccoon(rida[0], rida[1]));
}
sr.Close();
foreach (var item in tootajad)
{
    Console.WriteLine($"Nimi: {item.nimi}, Nahaalsus: {item.nahaalsus}");
}
Console.ReadLine();