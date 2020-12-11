using System;
using System.Diagnostics;

namespace ejercicio2
{ // PROBLEMA: Encontrar la suma de todos los numeros pares menores de 4,000,000 pertenecientes a la serie de Fibonacci 
    class Program
    {   
        // SOLUCION 1:
        public static long solucion1()
        {
            long num3 = 2;
            long num6 = 0;
            long resultado = 2;
            long suma = 0;

            while (resultado < 4_000_000)
            {
                suma += resultado;
                // Calcula el suguiente numero par de la serie usando solo numero pares.
                resultado = 4*num3 + num6;
                num6 = num3;
                num3 = resultado;
            }
            return suma;
        }

        // SOLUCION 2:
        public static long solucion2()
        {
            long[] fib = {2,0};
            int i = 0;
            long suma = 0;
            
            while (fib[i] < 4_000_000) 
            {
                suma += fib[i];
                // Alternar el valor de i entre 0 y 1.
                i = (i + 1) % 2;
                // Calcular el valor siguiente de la secuencia y la coloca en la posición "i" del array.
                fib[i] = 4 * fib[(i + 1) % 2] + fib[i];
            }
            return suma;
        }

        // SOLUCION 3: fuerza bruta
        public static int solucion3()
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
