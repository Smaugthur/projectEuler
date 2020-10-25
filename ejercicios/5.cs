using System;

namespace ejercicio5
{// PROBLEMA: Encontrar el menor número divisible entre todos los números pares del 1 a 20.
    class Program
    {
        public static int minimoComuMultiplo()
        {   
            // Variables iniciales: 
            int[] listaNum = new int[]{2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            int mcm = 1;
            int divisor = 2;
            int terminaBucle = 0;
            bool esDivisor = false;

            // Mientras no todos los numeros sean iguales a 1 continuar operando.
            while(terminaBucle != listaNum.Length)
            {   
                terminaBucle = 0;
                // Bucle que recorre cada elemento de la lista y lo divide si es posible.
                for(int i=0; i<listaNum.Length; i++)
                {
                    if(listaNum[i]%divisor == 0)
                    {
                        listaNum[i] /= divisor;
                        esDivisor = true;
                    }
                    // Incrementa termina Bucle si el valor del número es 1.
                    else if(listaNum[i]==1)
                        terminaBucle++;
                }
                // Chequeo para verificar si hay que cambiar el divisor o añadirlo a el mcm.
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