using System;
using System.Diagnostics;
using System.Threading;

namespace OrdenamientoBusqueda2024_1_GRAJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] A = { 5, 7, 1, 3, 12, 20, 8 };

            Stopwatch stopwatch = Stopwatch.StartNew();


            int[] A = Ordenamiento.Generar(373340);

            Console.WriteLine("**********Matriz Origínal**********");

           // Ordenamiento.Imprime(A);

            //Meidición del teimpo de ejecución 
            stopwatch.Start();
            Ordenamiento.Burbuja(A);
            stopwatch.Stop();

            Console.WriteLine("\n**********Matriz Origínal**********");
            //Ordenamiento.Imprime(A);

            Console.WriteLine("\n\nTimepo de ejecución del ordenamiento: {0}[ms]", stopwatch.ElapsedMilliseconds);


            Console.ReadLine();

        }
    }
}
