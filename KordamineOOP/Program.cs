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
Raccoon raccoon = new Raccoon(Raccoon.tougR.Eastern_raccoon, "Maksim", "black", Koduloom.sugu.isane, 10, 4, "8/10");
raccoon.print_Info();
raccoon.print_Haal();
Console.WriteLine(raccoon.print_Info());

using (StreamWriter writer = new StreamWriter("C:\\Users\\opilane\\source\\repos\\Artem Stryzhakov TARpv20\\raccoon.txt"))
{
    writer.WriteLine(raccoon.print_Info());
}
string readText = File.ReadAllText("C:\\Users\\opilane\\source\\repos\\Artem Stryzhakov TARpv20\\raccoon.txt");