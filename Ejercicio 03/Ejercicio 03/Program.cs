Console.Write("Ingrese el número de notas: ");
int nnot = int.Parse(Console.ReadLine());
int suma = 0;
int prom = 0;
for(int i = 1; i <= nnot; i++)
{
    Console.Write("Ingrese la nota " + i + ": ");
    int no = int.Parse(Console.ReadLine());
    suma = no + suma;
    prom = suma / nnot;
}
Console.Write("El promedio es " + prom);
Console.ReadKey();