using System;
using System.Diagnostics;

namespace ejercicio1
{ // PROBLEMA: encontrar la suma de los multiplos de 3 y 5 menores de 1000
    class Program
    {  
        // SOLUCIÓN OPTIMA
        public static int solucionOP(int numMax,int num1, int num2)
        {   
            int result = 0;
            // Bucle para sumar todos los multiplos de num1 y num2 menores de numMax.
            for (int i = 1; i < numMax; i++) 
            {
                // Si "i" es multiplo de num1 o num2 entonces sumalo a result.
                if ((i % num1) == 0 || (i % num2) == 0) 
                {
                    result += i;
                }
            }
            return result;
        }

        // SOLUCIÓN MÁS OPTIMA:
        public static int solucionOP2(int numMax, int numMin)
        {
            // Se resta 1 al número máximo para asegurar que es exclusivo, asi la suma es de multiplos menores de numMax.
            numMax -= 1;
            // Formula de Sucesion Aritmetica.
            return (numMax/numMin)*((2*numMin)+((numMax/numMin)-1)*numMin)/2;
        }
        

        // MI SOLUCION: 
        public static int miSolucion (int numMax, int numbase)
        {
            int multiplo = 0;
            int sumaMultiplos = 0;

            for(int i = 1 ; multiplo<numMax;)
            {
                // Para obtener un multiplo multiplicamos el número base por otros numero (i).
                multiplo = numbase*i;
                // Cada multiplo nuevo de la operación anterior se suman en sumaMultiplos.
                sumaMultiplos += multiplo;
                i++;
                // Para asegurar que el siguiente multiplo sea menor el numeroMax, y no entre en el ciclo.
                multiplo = numbase*i;
            }
            return sumaMultiplos;
        }
        // Obtiene los multiplos de los números dados correctamente, PERO no toma en cuenta que
        // pueden haber multiplos en común, esos multiplos en común los suma dos veces afectando la respuesta.
        // Por lo que hay que restarle el esos número restandole a la suma, la suma Total de los multiplos del multiplo que tienen en común.
    }
}