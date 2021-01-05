using System;

namespace exercise12
{// PROBLEM: A triangular series is the one where the "n" number is result the of 
 //          the sum of all the natural number up to it.
    class Program
    {   
        // SOLUTION 1: Brute Force 
        public static void solution1(int numDivisorMin)
        {
            long num=0;
            long n=0;
            int count=0;
            for(;true;n++)
            {
                // Calculate the next number
                num=num+n+1;
                
                // Calculate the number of divisors
                count=NumDivisors(num);
                
                // Check if the number satisfy the minimum No. of divisors
                if(count>numDivisorMin)
                {
                    Console.WriteLine("*"+num);
                    break;
                }
            }
        }
        public static int NumDivisors(long num)
        {
            int count=0;
            for(long e=2;e*e<=num;e++)
            {
                if(num%e==0)
                {
                    count++;
                    if(num/e!=e) // To avoid duplicate divisors
                        count++; 
                }
            }
            return count;
        }
    }
}
