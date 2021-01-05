using System;
using System.Collections.Generic;

namespace exercise10
{// PROBLEM: find the sum of the all the primes numbers under 2,000,000

    class Program
    {   // SOLUTION 1: using the Eratosthenes
        public static long solution1(int max)
        {
            long primeSum=2;
            bool isPrime=true;
            List<int> Primes= new List<int>();
            Primes.Add(2);

            for(int i=3; i<max; i+=2)
            {
                for(int e=0;Primes[e]<=Math.Sqrt(i); e++)
                {
                    if(i%Primes[e]==0)
                    {
                        isPrime=false;
                        break;
                    }
                }
                if(isPrime)
                {
                    primeSum+=i;
                    Primes.Add(i);
                    //Console.WriteLine(i);
                }
                isPrime=true;
            }

            return primeSum; 
        }

        // SOLUTION 2: Brute force
        public static long solution2(long max)
        {   
            long primeSum=2;
            bool isPrime=true;
            for(int i=3; i<max;i+=2)
            {
                for(int e=3; e*e<=i; e++)
                {
                    if(i%e==0)
                    {
                        isPrime=false;
                        break;
                    }
                }
                if(isPrime)
                {
                    primeSum+=i;
                    //Console.WriteLine(i);
                }
                isPrime=true;
            }
            return primeSum;
        }
    }
}
