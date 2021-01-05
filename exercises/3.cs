using System;

namespace exercise3 
{// PROBLEM: find the biggest prime factor from 600851475143.
    class Program
    {
        // SOLUTION 1: Aritmetic fundamental theorem.
        public static long solution1(long num)
        {                
            long numTemp = num;
            long primeFactor= 0;
            long counter = 2;
            while(counter*counter<numTemp)
            {
                if(numTemp%counter==0)
                {
                    numTemp /= counter;
                    primeFactor = counter;
                }
                else
                    counter ++;
            }
            if (numTemp>counter)
            {
                primeFactor = numTemp;
            }
            return primeFactor;
        }

        // SOLUTION 2: Brute force 
        public static long solution2(long num)
        {
            bool divisor = false;
            long primeFactor = 0;

            for(long i=2; i*i<num ;i++)
            {
                if (num%i == 0)
                {                        
                    divisor = true;
                    for(long e=2; e*e < i;e++)
                    {
                        if(i%e == 0)
                        {
                            divisor = false;
                            break;
                        }
                    }
                    primeFactor = (divisor)? i: primeFactor;
                }
            }
            return primeFactor;
        }
        
    }
}
