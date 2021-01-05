using System;
using static System.Math;

namespace exercise9
{// PROBLEM: A Pythagorean triplet its a set of 3 natural numbers where a<b<c. That comply The
 //          Pythagorean Teorem. There's a Pythagorean triplet where a+b+c=1000.
 //          Find the the producto of a,b,c. 
    class Program
	{
		// SOLUTION 1: Brute Force
        public static int solution1(int max)
        {
            int c = 0, product= 0;
            for(int a=1; a<max; a++)
            {
                for (int b=1; b<a; b++)
                {
                    c=max-a-b;
	                if(a*a+b*b == c*c)
                    {
                        product=a*b*c;
                        Console.WriteLine("a="+a+" b="+b+" c="+c);
                        break;
                    }
                }
            }
            return product;
        }

        // SOLUTION 2: Euclidean Method
        // NOTE: this solution only works for primitive triplets.
        public static int solution2(int max)
        {
            int m=0, n=1, product=0; 
            int lim=max/2;
            while(true)
            {
                m=(int) Sqrt(lim+(n*n)/2)-(n/2);
                if(m*(m+n)==lim)
                {
                    Console.WriteLine(m);
                    Console.WriteLine(n);
                    product= (m*m-n*n) * (2*m*n) * (m*m+n*n);
                    break;  
                }
                n++;
            }
            return product;
        }
	}
}
