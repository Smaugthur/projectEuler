using System;

namespace ejercicio5
{// PROBLEMA: Encontrar el menor número divisible entre todos los números pares del 1 a 20.
    class Program
    {
        public static int minimoComuMultiplo()
        {
            int[] listaNum = new int[]{2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            int mcm = 1;
            int divisor = 2;
            int terminaBucle = 0;
            bool esDivisor = false;

            while(terminaBucle != listaNum.Length)
            {   
                terminaBucle = 0;
                for(int i=0; i<listaNum.Length; i++)
                {
                    if(listaNum[i]%divisor == 0)
                    {
                        listaNum[i] /= divisor;
                        esDivisor = true;
                    }
                    else if(listaNum[i]==1)
                        terminaBucle++;
                }
                if(esDivisor)
                {
                    mcm*=divisor;
                    esDivisor=false;
                }
                else
                    divisor++;
            }
            return mcm;
        }
    }
}