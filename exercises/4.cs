using System;

namespace exercise4
{// PROBLEM: Find the largest palindrome made by the product of two 3-digit numbers.
    class Program
    {

        // SOLUTION 1: find the largest palindrome and then its factors.
		public static void solution1()
		{
            long Palindrome = 0;
            long factor1 = 0;
            long factor2 = 0;
			// Start from the MAX number and descend from there.
            for(long i = 998001; i>11111 ;i--)
            {
                if(i == otros.Program.Invert_Number_M(i))
                {
                    for(long e = 100; e<1000; e++)
                    {
                        if(i%e == 0)
                        {
                            long numTemp = i/e;
                            if(numTemp > 99 && numTemp < 1000)
                            {
								factor1=e;
								factor2=numTemp;
                                Palindrome = i;
								break;
                            }
                        }
                    }
					if(Palindrome != 0)
						break;
                }
            }
            Console.WriteLine($"Palindrome: {Palindrome}\nfactor 1: {factor1}\nfactor 2: {factor2}");
		}

        //SOLUTION 2: find the largest palindrome and then its factors.
        public static void solution2()
        {
            long Palindrome = 0;
            long factor1 = 0;
            long factor2 = 0;
            // Start from the MIN number and ascend from there.
            for(long i = 11111; i<998001;i++)
            {
                if(i == otros.Program.Invert_Number_M(i))
                {
                    for(long e = 100; e<1000; e++)
                    {
                        if(i%e == 0)
                        {
                            long numTemp = i/e;
                            if(numTemp > 99 && numTemp < 1000)
                            {
                                factor1=e;
	                            factor2=numTemp;
                                Palindrome = i;
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Palindrome: {Palindrome}\nfactor 1: {factor1}\nfactor 2: {factor2}");
        }
    }
}
