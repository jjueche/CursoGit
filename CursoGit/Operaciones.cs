namespace CursoGit
{
    public static class Operaciones
    {
        public static void Tabla()
        {
            Console.Write("De que número desea la tabla de multiplicar?: ");
            int nro = Convert.ToInt32(Console.ReadLine());
            int resultado;
            for (int i = 1; i <= 10; i++)
            {
                resultado = i * nro;
                Console.WriteLine(i.ToString() + " x " + nro.ToString() + " = " + resultado.ToString());
            }
            Console.ReadLine();
        }

        public static void Multiplicar(int nro1, int nro2)
        {
            

            Console.WriteLine(nro1 * nro2);
        }
    }
}
