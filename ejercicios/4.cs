using System;

namespace ejercicio4
{
    class Program
    {// PROBLEMA: el numero palidromo más largo producto de 2 números de 3 cifras.
        public static long MiSolucion()
        {
            // Para encontrar el mayor numero palindromo:
            long Palindromo = 0;
            for(long i = 1000; i<998_001; i++)
            {
                if(i == otros.Program.Invierte_numero_M(i))
                    Palindromo = i;
            }
            // Para encontrar sus factores:
            
            return Palindromo;
        }
    }
}