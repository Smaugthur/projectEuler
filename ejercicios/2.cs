using System;
using System.Diagnostics;

namespace ejercicio2
{
    class Program
    {   

        public static int fibonacci()
        {
            int num1 = 1;
            int num2 = 2;
            int fibonacciNumber = 0;
            int SumaTotal = 0;

            while(1>0)
            {
                fibonacciNumber = num1 + num2;
                num1=num2;
                num2=fibonacciNumber;

                if (fibonacciNumber > 4_000_000)
                    break;
                
                if((fibonacciNumber - 1) % 2 == 0)
                {
                    SumaTotal += fibonacciNumber;
                }
            }

            return SumaTotal;
        }
    }
} 