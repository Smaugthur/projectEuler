using System;

namespace ejercicio3
{
    class Program
    {// PROBLEMA: Encontrar el factor primo más grande de 600851475143.
  
        // SOLUCION 1: Teorema Fundamental de la Aritmetica. 
        public static long solucion1(long num)
        {                
            long numeroTemp = num;
            long factorPrimo= 0;
            long contador = 2;
            while(contador*contador<numeroTemp)
            {
                if(numeroTemp%contador==0)
                {
                    numeroTemp /= contador;
                    factorPrimo = contador;
                }
                else
                    contador ++;
            }
            if (numeroTemp>contador)
            {
                factorPrimo = numeroTemp;
            }
            return factorPrimo;
        }

        // SOLUCION 2: fuerza bruta 
        public static long solucion2(long num)
        {
            bool divisor = false;
            long factorPrimo = 0;

            for(long i=2; i*i<num ;i++)
            {
                if (num%i == 0)
                {                        
                    divisor = true;
                    for(long e=2; e*e < i;e++)
                    {
                        if(i%e == 0)
                        {
                            divisor = false;
                            break;
                        }
                    }
                    factorPrimo = (divisor)? i: factorPrimo;
                }
            }
            return factorPrimo;
        }
        
    }
}
