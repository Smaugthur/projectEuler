using System;

namespace otros
{
    class Program
    {
        // VERSION OPTIMA:
        public static long Invierte_numeroOP(long num)
        {
            long originalNumber = num;
            long remainder, reverseNumber = 0;
            
            // Termina cuando la division por 10 de originalNumber se trunque 0
            while (originalNumber > 0)
            {
                // Para aislar la ultima cifra del numero.
                remainder = originalNumber % 10;
                // Multiplica el numero del ciclo anterior por 10 (para subirlo una cifra) y le suma el ultimo numero.
                reverseNumber = reverseNumber * 10 + remainder;
                // Corta la ultima cifra del numero fuente (al dividir por 10 se hace decimal y se trunca) para que en el siguien ciclo se usa la otra cifra.
                originalNumber /= 10;
            }
            return reverseNumber;
        }
    }
}