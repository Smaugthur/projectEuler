using System;
using System.Diagnostics;

namespace ejercicio1
{
    class Program
    {  
        static void Main(string[] args)
        {
            Console.WriteLine(solucionOP(1000,3,5));
            Console.WriteLine(sumaMultiplos(1000,3) + sumaMultiplos(1000,5));
        }

        
        // SOLUCIÓN MÁS OPTIMA
        static int solucionOP(int numeroMax,int num1, int num2)
        {   
            int result = 0;
            for (int i = 1; i < numeroMax; i++) 
            {
                if ((i % num1) == 0 || (i % num2) == 0) 
                {
                    result += i;
                }
            }
            return result;
        }
        
        // SOLUCION INCORRECTA: obtiene los multiplos de los números dados correctamente, PERO no toma en cuenta que
        //                      pueden haber multiplos en común, esos multiplos en común los suma dos veces afectando la respuesa.
        static int sumaMultiplos (int numeroMax, int numerobase)
        {
            int multiplo = 0;
            int sumaMultiplos = 0;

            for(int i = 1 ; multiplo<numeroMax;)
            {
                // Para obtener un multiplo multiplicamos el número base por otros numero (i).
                multiplo = numerobase*i;
                // Cada multiplo nuevo de la operación anterior se suman en sumaMultiplos.
                sumaMultiplos += multiplo;
                i++;
                // Para asegurar que el siguiente multiplo sea menor el numeroMax, y no entre en el ciclo.
                multiplo = numerobase*i;
            }
            return sumaMultiplos;
        }
    }
}