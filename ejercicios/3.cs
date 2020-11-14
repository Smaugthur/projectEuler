using System;

namespace ejercicio3
{
    class Program
    {// PROBLEMA: Encontrar el factor primo más grande de 600851475143.
        // MI SOLUCION
        public static long miSolucion(long num)
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

        // SOLUCION OP
        public static long solucionOP(long num)
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
    }
}