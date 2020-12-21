using System;
using System.Collections.Generic;

namespace ejercicio10
{// PROBLEMA: encontrar la suma de todos los numero primos < 2,000,000

    class Program
    {   // SOLUCION 2: usando criba de Erastotenes
        public static long solucion1(int max)
        {
            long sumaPrimos=2;
            bool esPrimo=true;
            List<int> Primos= new List<int>();
            Primos.Add(2);

            for(int i=3; i<max; i+=2)
            {
                for(int e=0;Primos[e]<=Math.Sqrt(i); e++)
                {
                    if(i%Primos[e]==0)
                    {
                        esPrimo=false;
                        break;
                    }
                }
                if(esPrimo)
                {
                    sumaPrimos+=i;
                    Primos.Add(i);
                    //Console.WriteLine(i);
                }
                esPrimo=true;
            }

            return sumaPrimos; 
        }

        // SOLUCION 2: fuerza bruta
        public static long solucion2(long max)
        {   
            long sumaPrimos=2;
            bool esPrimo=true;
            for(int i=3; i<max;i+=2)
            {
                for(int e=3; e*e<=i; e++)
                {
                    if(i%e==0)
                    {
                        esPrimo=false;
                        break;
                    }
                }
                if(esPrimo)
                {
                    sumaPrimos+=i;
                    //Console.WriteLine(i);
                }
                esPrimo=true;
            }
            return sumaPrimos;
        }
    }
}
