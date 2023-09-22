Console.Write("Ingrese el número 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el número 2: ");
int num2 = int.Parse(Console.ReadLine());

int resultado = 0;
for (int i = 1; i <= num2; i++)
{
    resultado = resultado + num1;
}
Console.WriteLine("El producto es " + resultado);
Console.ReadKey();