using System;

namespace exercise6
{// PROBLEM: Find the difference of the square of the sum of numbers from 1 to 100
 //          and the sume of squares from 1 to 100:
 //           (S)^2 - (S^2) 
    class Program
    {

        // SOLUTION : using Series Series formulas.
        public static long solution(int numMax)
        {
            int minuend = 0; 
            int substracting = 0;
            minuend = (numMax/1) * (numMax+1)/2;
            substracting = (numMax * (numMax + 1) * (2 * numMax + 1)) / 6;
            return minuend*minuend - substracting;
        }
    }
}

