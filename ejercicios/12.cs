using System;

namespace ejercicio12
{// PROBLEMA: Una serie triangular es aquella donde el numero "n" es resultado
 //           de la suma de todos numeros naturales hasta "n".
 //           Encontrar el primer numero de la serie con 500 divisores.
    class Program
    {   
        public static void solucion2(int divisorMax)
        {
            long num=0;
            long n=0;
            int contador=0;
            while(true)
            {
                num=num+n+1;
                n++;
                
                contador=0;
                for(long e=2;e*e<=num;e++)
                {
                    if(num%e==0)
                    {
                        contador++;
                        if(num/e!=e)
                            contador++; 
                    }
                }

                if(contador>divisorMax)
                {
                    Console.WriteLine("*"+num);
                    break;
                }
            }
        }
        public static int NumDivisores(long num)
        {
            int contador=0;
            for(long i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    contador++;
                    long Temp=(num/i);
                    if(Temp!=i)
                        contador++;
                }
            }
            return contador;
        }
    }
}
