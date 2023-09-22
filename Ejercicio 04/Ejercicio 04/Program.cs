Console.Write("Ingrese el número límite: ");
int numl = int.Parse(Console.ReadLine());
Console.WriteLine("==========================");
Console.WriteLine("Escoja una opción:");
Console.WriteLine("1: Números pares ");
Console.WriteLine("2: Números impares");
Console.WriteLine("3: Factorial");
Console.Write("->");
int opc = int.Parse(Console.ReadLine());
switch (opc)
{
    case 1:
        for (int i = 2 ; i <= numl ; i +=2 )
        {
            Console.Write(i + ", ");
        }
        break;
    case 2:
        for (int i = 1 ; i <= numl ; i += 2 )
        {
            Console.Write(i + ", ");
        }
        break;
    case 3:
        long fac = 1;
        for (int i = 1 ; i <= numl ; i++)
        {
            fac = fac * i;
        }
        Console.WriteLine(fac);
        break;
}
Console.ReadKey();