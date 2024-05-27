using CursoGit;

Console.WriteLine("Mini-calculadora");
Console.WriteLine("Que operación desea realizar?");
Console.WriteLine("1. Tabla de multiplicar");
Console.WriteLine("2. Multiplicar dos números");
Console.WriteLine("3. Sumar dos números");
Console.WriteLine("4. Dividir dos números");
Console.WriteLine("5. Restar dos números");
int opcion = Convert.ToInt32(Console.ReadLine());
int primerOperando = 0;
int segundoOperando = 0;
if (opcion != 1)
{
    Console.WriteLine("Digite el primer operando");
    primerOperando = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el segundo operando");
    segundoOperando = Convert.ToInt32(Console.ReadLine());
}
switch (opcion)
{
    case 1: Operaciones.Tabla();
        break;
    case 2: Operaciones.Multiplicar(primerOperando, segundoOperando);
        break;
    case 3: Console.WriteLine(primerOperando + segundoOperando);
        break;
}



