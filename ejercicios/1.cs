using System;
using System.Diagnostics;

namespace ejercicio1
{ // PROBLEMA: encontrar la suma de los multiplos de 3 y 5 menores de 1000
    class Program
    {  
        // SOLUCION 1: formula de Sucesion Aritmetica.
        public static int solucion1(int numMax, int numMin)
        {
            // restar 1 para asegurar que excluye numMax.
            numMax -= 1;
            // Formula de Sucesion Aritmetica.
            return (numMax/numMin)*((2*numMin)+((numMax/numMin)-1)*numMin)/2;
        }


        // SOLUCION 1: fuerza bruta
        public static int solucion2(int numMax,int num1, int num2)
        {   
            int result = 0;
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

        // SOLUCION 3: fuerza bruta
        public static int Solucion3 (int numMax, int numbase)
        {
            int multiplo = 0;
            int sumaMultiplos = 0;

            for(int i = 1 ; multiplo<numMax;)
            {
                multiplo = numbase*i;
                sumaMultiplos += multiplo;
                i++;
                // Asegurar que el siguiente multiplo sea menor a numMax.
                multiplo = numbase*i;
            }
            return sumaMultiplos;
        }
        // Obtiene los multiplos de los números dados correctamente,
        // pero pueden haber multiplos en común, que se suman más de 1 vez
        // esto se soluciona: sumaTotal - sumaDeMCM
    }
}
