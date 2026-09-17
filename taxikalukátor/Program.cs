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
Console.WriteLine("alapdíj(egész szám):");
int dij = int.Parse(Console.ReadLine());
Console.WriteLine("kilometer díj:");
int kildij = int.Parse(Console.ReadLine());
double eszakaipotlek = 1.20;
///3.feladat
int osszeg = ut*kildij+dij;
if (esti==true)
{
    osszeg = (int)(osszeg * eszakaipotlek);
}