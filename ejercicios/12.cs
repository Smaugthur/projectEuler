using System;

namespace ejercicio12
{// PROBLEMA: Una serie triangular es aquella donde el numero "n" es resultado
 //           de la suma de todos numeros naturales hasta "n".
 //           Encontrar el primer numero de la serie con mas de 500 divisores.
    class Program
    {   
        // SOLUCION 2: fuerza bruta
        public static void solucion2(int numDivisorMin)
        {
            long num=0;
            long n=0;
            int contador=0;
            for(;true;n++)
            {
                // Calcula num siguiente
                num=num+n+1;
                
                // Calcula no divisores
                contador=NumDivisores(num);
                
                // Chequea si cumple el minimo de divisores posibles.
                if(contador>numDivisorMin)
                {
                    Console.WriteLine("*"+num);
                    break;
                }
            }
        }
        public static int NumDivisores(long num)
        {
            int contador=0;
            for(long e=2;e*e<=num;e++)
            {
                if(num%e==0)
                {
                    contador++;
                    if(num/e!=e) // Para evitar duplicar divisores
                        contador++; 
                }
            }
            return contador;
        }
    }
}
