Console.Write("Ingrese la base:");
int bas = int.Parse(Console.ReadLine());
Console.Write("Ingrese el exponente:");
int exp = int.Parse(Console.ReadLine());
int pot = 1;
for(int i = 0; i < exp; i++)
{
    pot = pot * bas;
}
Console.WriteLine("La potencia es " + pot);
Console.ReadKey();