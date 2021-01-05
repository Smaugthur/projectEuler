using System;

namespace exercise14
{/* PROBLEM: the Collatz sequence it's made taking a "n" number, such that:

  ⇒ n/2  <- if "n" is even
  ⇒ 3n+1 <- if "n" is odd

  If this operations were made repeatedly starting from a inicial number "n" it is
  almost proved that we always reach to 1 at some point of the sequence.

  What is the number, smaller than 1 million, with more steps to reach 1?
 */
    class Program
    {
        // SOLUTION 1: Brute Force
        public static void solution1()
        {
            long n=0;
            int countFinal=0;
            int countParcial=0;
            for(long i=1;i<1_000_000; i++)
            {
                long e = i;
                while(e!=1)
                {
                    if(e%2==0)
                        e/=2;
                    else
                        e=(3*e)+1;
                    countParcial++;
                }
                if(countParcial>countFinal)
                {
                    countFinal=countParcial;
                    n=i;
                }
                countParcial=0;
            }
            Console.WriteLine(n+" "+countFinal);
        }

        // SOLUTION 2: Brute Force but using numbers of the sequence that have already
        //             been calcualted.
        public static void solution2()
        {
            long n=0;
            int countFinal=0;
            int countParcial=0;
            int[] sequence= new int[1_000_000];

            for(long i=1; i<1_000_000; i++)
            {
                long e=i;
                countParcial=0;
                while(e!=1 && e>=i)
                {
                    if(e%2==0)
                        e/=2;
                    else
                        e=(3*e)+1;
                    countParcial++;
                }

                countParcial=countParcial+sequence[e];
                sequence[i]=countParcial;

                if(countParcial>countFinal)
                {
                    n=i;
                    countFinal=countParcial;
                }
            }
            Console.WriteLine(n+" "+countFinal);
        }
    }
}
