using System;
using System.IO;
using System.Numerics;

namespace exercise13
{ // PROBLEM: Sum the 50 numbers that are written in the file "/src/tex_ej_13" and write the first
  // 10 digits of the result.
    class Program
    {
        // SOLUTION 1: Use the "BigInteger" class to record large numbers.
        public static void solution1()
        {
            BigInteger sum = new BigInteger(); 
            TextReader r = new StreamReader("./src/tex_ej_13.txt");
            string line;

            while ((line=r.ReadLine()) != null)
            {
                sum+=BigInteger.Parse(line);
            }
            r.Close();

            Console.WriteLine(sum);
        }
    }
}
