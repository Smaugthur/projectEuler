using System;
using System.Numerics;

namespace exercise16
{// PROBLEM: 2^10 = 32768 and the sum of its 3 + 2 + 7 + 6 + 8 = 26
//           What is the sum of the digits of the number 2^1000 ? 
    class Program
    {
        // SOLUTION 1: implementing de BigInteger type to recorde this big pow.
        public static int solution1()
        {
            BigInteger number = BigInteger.Pow(2, 1000);
            int sum = 0;
            while(number>0)
            {
                sum += (int) (number % 10);
                number /= 10;
            }
            return sum;
        }
    }
}