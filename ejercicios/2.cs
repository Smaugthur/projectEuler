using System;
using System.Diagnostics;

namespace ejercicio2
{
    class Program
    {   
        // SOLUCION OP
        public static long SolucionOP1()
        {
            long num3 = 2;
            long num6 = 0;
            long resultado = 2;
            long suma = 0;

            while (resultado < 4_000_000)
            {
                suma += resultado;
                // resultado implementa un despeje para calcular el números pares de la serie sabiendo números pares anteriores.
                resultado = 4*num3 + num6;
                num6 = num3;
                num3 = resultado;
            }
            return suma;
        }

        // SOLUCION MÁS OP
        public static long SolucionOP2()
        {
            long[] fib = {2,0};
            int i = 0;
            long suma = 0;
            
            while (fib[i] < 4_000_000) 
            {
                suma += fib[i];
                // Esta operacion alterna los valores de 0 a 1 de "i" y así alternar entre los 2 elementos del array.
                i = (i + 1) % 2;
                // Calcular el valor siguiente de la secuencia y la coloca en la posición "i" del array.
                fib[i] = 4 * fib[(i + 1) % 2] + fib[i];
            }
            return suma;
        }

        // MI SOLUCION
        public static int miSolucion()
        {
            int num1 = 1;
            int num2 = 2;
            int fibonacciNumber = 0;
            int SumaTotal = 2;

            while(fibonacciNumber < 4_000_000)
            {
                fibonacciNumber = num1 + num2;
                num1=num2;
                num2=fibonacciNumber;
                
                if(fibonacciNumber % 2 == 0)
                {
                    SumaTotal += fibonacciNumber;
                }
            }
            return SumaTotal;
        }
    }
}