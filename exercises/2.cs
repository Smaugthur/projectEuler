using System;
using System.Diagnostics;

namespace exercise2 
{// PROBLEM: Find the sum of all the even numbers less than 4,000,000 that belongs to the Fibonacci series.
    class Program
    {   
        // SOLUTION 1: Calculing just even numbers of the series.
        public static long solution1()
        {
            long num3 = 2;
            long num6 = 0;
            long result = 2;
            long sum = 0;

            while (result < 4_000_000)
            {
                sum += result;
                // Calculate the next even number from the series using only even numbers.
                result = 4*num3 + num6;
                num6 = num3;
                num3 = result;
            }
            return sum;
        }

        // SOLUTION 2: using an array to save the values.
        public static long solution2()
        {
            long[] fib = {2,0};
            int i = 0;
            long sum = 0;
            
            while (fib[i] < 4_000_000) 
            {
                sum += fib[i];
                // Alternate i between 0 and 1.
                i = (i + 1) % 2;
                // Calculate the next value of the sequence and place it in the "i" position of the array.
                fib[i] = 4 * fib[(i + 1) % 2] + fib[i];
            }
            return sum;
        }

        // SOLUTION 3: Brute force
        public static int solution3()
        {
            int num1 = 1;
            int num2 = 2;
            int fibNumber = 0;
            int totalSum = 2;

            while(fibNumber < 4_000_000)
            {
                fibNumber = num1 + num2;
                num1=num2;
                num2=fibNumber;
                
                if(fibNumber % 2 == 0)
                {
                    totalSum += fibNumber;
                }
            }
            return totalSum;
        }
    }
}
