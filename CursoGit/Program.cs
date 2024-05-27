using CursoGit;

Console.WriteLine("Mini-calculadora");
Console.WriteLine("Que operación desea realizar?");
Console.WriteLine("1. Tabla de multiplicar");
Console.WriteLine("2. Multiplicar dos números");
Console.WriteLine("3. Sumar dos números");
Console.WriteLine("4. Dividir dos números");
Console.WriteLine("5. Restar dos números");
int opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1: Operaciones.Tabla();
        break;
    
}



