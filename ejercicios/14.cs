using System;

namespace ejercicio14
{/* PROBLEMA: la secuencia de Collatz se elabora al tomar un numero "n", tal que
 
  ⇒ n/2  <- si "n" es par
  ⇒ 3n+1 <- si "n" es impar

  Si se hace estas operaciones repetidamente a partir de un numero inicial "n" se
  cree que siempre se llegara a 1.

  Cual es el número, menor de 1 millon, con más pasos para llegar a 1?

 */
    class Program
    {
        // SOLUCION 1: Fuerza Bruta
        public static void solucion1()
        {
            long n=0;
            int cont=0;
            int cont2=0;
            for(long i=1;i<1_000_000; i++)
            {
                long e = i;
                while(e!=1)
                {
                    if(e%2==0)
                        e/=2;
                    else
                        e=(3*e)+1;
                    cont2++;
                }
                if(cont2>cont)
                {
                    cont=cont2;
                    n=i;
                }
                cont2=0;
            }
            Console.WriteLine(n+" "+cont);
        }
    }
}
