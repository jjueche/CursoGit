// See https://aka.ms/new-console-template for more information

Console.Write("De que número desea la tabla de multiplicar?: ");
int nro = Convert.ToInt32(Console.ReadKey());
int resultado = 0;
for (int i = 1;i <= 10;i++)
{
    resultado = i * nro;
    Console.WriteLine(i.ToString() + " x " + nro.ToString() + " = " + resultado.ToString());
}
Console.ReadLine();

