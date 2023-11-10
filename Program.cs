using System;
using System.Threading;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*int[] A = { 5, 7, 1, 3, 12, 20, 8 };
            int[] A = { 1, 3, 5, 7, 8, 12, 20 };
            int x = 12;
            //int i = Busqueda.Lineal(A, x);
            int i = Busqueda.Binaria(A, 0, A.Length, x);
            if (i!= -1)
            {
                Console.WriteLine("El valor {0} está en la posición {1}",x,i);
            }
            else
            {
                Console.WriteLine("Número no encontrado");
            }*/
            

           Stopwatch sw = new Stopwatch();

            int[] A = Ordenamiento.Generar(100000);
           // Console.WriteLine("Matriz Original");
            // Ordenamiento.Imprime(A);
           // Midiendo tiempo de ejecución 
            sw.Start();
            Ordenamiento.Baraja(A);
            sw.Stop(); //termina de medir

            // Console.WriteLine("\n\n****Matriz Ordenada****");
            //Ordenamiento.Imprime(A);
            Console.WriteLine("\n\nTiempo de ejecución del ordenamiento: {0} [ms]", sw.ElapsedMilliseconds);
            Console.ReadLine();

        }
    }
}
