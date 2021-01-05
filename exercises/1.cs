using System;
using System.Diagnostics;

namespace exercise1
{// PROBLEM: find the sum of the multiples of 3 and 5 below 1000.
    class Program
    {  
        // SOLUTION 1: Arithmetic succession formula.
        public static int solution1(int numMax, int numMin)
        {
            // subtract 1 to make sure numMax is exluded.
            numMax -= 1;
            // Succession Arithemetic formula
            return (numMax/numMin)*(numMin+numMax)/2;
        }


        // SOLUTION 2: Brute force
        public static int solution2(int numMax,int num1, int num2)
        {   
            int result = 0;
            for (int i = 1; i < numMax; i++) 
            {
                // If "i" is multiple of num1 or num2 then sum it to the result.
                if ((i % num1) == 0 || (i % num2) == 0) 
                {
                    result += i;
                }
            }
            return result;
        }

        // SOLUTION 3: Brute force
        public static int solution3 (int numMax, int numbase)
        {
            int multiple = 0;
            int multipleSum = 0;

            for(int i = 1 ; multiple<numMax;)
            {
                multiple = numbase*i;
                multipleSum += multiple;
                i++;
                // Make sure the next number is below numMax.
                multiple = numbase*i;
            }
            return multipleSum;
        }
        // Get the given multiples correctly,
        // but can be common multiples between the given numbers, that are sum twice
        // this is solved by: totalSum - LCMsum
    }
}
