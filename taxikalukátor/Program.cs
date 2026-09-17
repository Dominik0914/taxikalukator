///2.feladat
Console.WriteLine("kérem az utas nevét:");
string utasnev = Console.ReadLine();
Console.WriteLine("megtett út?(egész szám,km):");
int ut = int.Parse(Console.ReadLine());
bool esti=false;
Console.WriteLine("esti utazás volt?(igen/nem):");
string estiValasz = Console.ReadLine();
if (estiValasz == "igen")
{
    esti = true;
}

int dij = 1100;
int kildij = 440;
double eszakaipotlek = 1.20;
///3.feladat
int ujosszeg=0;
int osszeg = ut*kildij+dij;
if (esti==true)
{
    ujosszeg = (int)(osszeg * eszakaipotlek);
}
///4.feladat
Console.WriteLine($"Utas neve: {utasnev}");
Console.WriteLine($"Megtett távolság:{ut}km");
Console.WriteLine($"Alapérték:{osszeg}");
if (esti == true)
{
    Console.WriteLine($"Fizetendő végösszeg:{ujosszeg}");
}
else
{
    Console.WriteLine($"Fizetendő végösszeg:{osszeg}");
}

if (esti == true)
{
    Console.WriteLine($"Státus:20% éjszakai pótlék felszámolva");
}
else
{
    Console.WriteLine($"Státus:Nincs 20% éjszakai pótlék felszámolva");
}
