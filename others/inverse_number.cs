using System;
using System.Text;

namespace otros
{
    class Program
    {
        // MATHEMATIC VERSION:
        public static long Invert_Number_M(long num) {
            long numOriginal = num;
            long residue, invertedNum= 0;
            
            // Ends when the division by 10 of originalNumber truncate to 0.
            while (numOriginal> 0)
            {
                // To isolate the last digit of the number.
                residue = numOriginal % 10;
                // Multiply the last cicle number by 10 (to gain 1 digit) y then sum the last number.
                invertedNum = invertedNum * 10 + residue;
                // Cut the last digit of the Original number (by dividing by 10 it becomes a decimal to truncate) 
                // in order to use the next digit in the next cycle.
                numOriginal /= 10;
            }
            return invertedNum;
        }

        //NO MATHEMATIC VERSION: 
        public static void Invert_Number_NM(long num)
        {
            string numTemp= Convert.ToString(num);
            char[] List = new char[numTemp.Length];
            int count = numTemp.Length-1;
            // Loop that cycle through the original number's digits and add them to the array,
            // starting from the last position in the array.
            foreach(char i in numTemp)
            {
                List[count]= i;
                count--;
            }
            Console.WriteLine(List);
        }
    }
}
