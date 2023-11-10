using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Busqueda
    {
        internal static int Lineal(int[] A, int x)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == x)
                {
                    return i;
                }

            }
            return -1;

        }


        internal static int Binaria(int[] A, int IZQ, int DER, int X)
        {
            if (IZQ >= DER)
            {
                return -1;
            }
            else
            {
                int CEN = (IZQ + DER) / 2;

                if (A[CEN] == X)
                {
                    return CEN;
                }
                else if (X < A[CEN])
                {
                    return Binaria(A, IZQ, CEN, X);
                }
                else
                {
                    return Binaria(A, CEN, DER, X);
                }


            }



        }
    }
}
