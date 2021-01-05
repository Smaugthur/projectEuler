using System;

namespace exercise5
{// PROBLEM: find the smallest number that can be divided by all the numbers from 1 to 20.
    class Program
    {
        // SOLUTION 1: Prime numbers factorization.
        public static int solucion()
        {   
            int[] numList = new int[]{2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            int lcm = 1;
            int divisor = 2;
            int endLoop = 0;
            bool isDivisor = false;

            // While not all the numbers are iqual to 1 still calculating.
            while(endLoop != numList.Length)
            {   
                endLoop = 0;
                // Loop that cycle through each element of the list and divide it if possible.
                for(int i=0; i<numList.Length; i++)
                {
                    if(numList[i]%divisor == 0)
                    {
                        numList[i] /= divisor;
                        isDivisor = true;
                    }
                    // Increments <endLoop> if the number's value equals to1.
                    else if(numList[i]==1)
                        endLoop++;
                }
                // Check to verify if the divisor have to change or add it to the lcm.
                if(isDivisor)
                {
                    lcm*=divisor;
                    isDivisor=false;
                }
                else
                    divisor++;
            }
            return lcm;
        }
    }
}
