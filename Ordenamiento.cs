using System;
using System.Threading;

namespace ConsoleApp1
{
    internal class Ordenamiento
    {
        internal static int[] Generar(int N)
        {
            Random aleatorio = new Random();
            int[]A = new int[N];
            for (int i=0; i < N; i++)
            {
                A[i] = (int)(aleatorio.NextDouble() * 10000);
            }
            return A;



        }
        internal static void Imprime(int[] A)
        {
            foreach (int a in A)
            {
                Console.Write("{0}   ",a);
            }
        }
        internal static void Burbuja(int[] A)
        {
            int N = A.Length;
            for (int i= 0; i < N; i++)
            {
                for (int j= 0; j < N-1; j++)
                {
                    if ( !(A[j] < A[j + 1]))
                    {
                        int Aux = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = Aux;
                    }
                }
            }
        }
        internal static void Quicksort(int[] A, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = A[central];
            i = primero;
            j = ultimo;
            do
            {
                while (A[i] < pivote) i++;
                while (A[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                Quicksort(A, primero, j);
            }
            if (i < ultimo)
            {
                Quicksort(A, i, ultimo);
            }
        }
        internal static void Baraja(int[] A)
        {
            int x = A.Length;
            for (int i = 1; i < x; ++i)
            {
                int key = A[i];
                int j = i - 1;
                while (j >= 0 && A[j] > key)
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }

                A[j + 1] = key;
            }
        }

    }
}

