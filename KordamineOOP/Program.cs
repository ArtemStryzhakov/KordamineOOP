using KordamineOOP;
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");
Koer koer = new Koer(Koer.toug.Mops, "Šarik", "punane", Koduloom.sugu.isane, 35.5, 7, true);
koer.print_Info();
koer.print_Haal();
Koer veelkoer = new Koer(koer);
veelkoer.muudaNimi("Mopsjara");
veelkoer.muudaVarv("valge");
veelkoer.muudaSugu(Koduloom.sugu.isane);
veelkoer.muudaKaal(7.2);
veelkoer.muudaKaal(3);
veelkoer.print_Info();