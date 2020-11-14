using System;
using System.Text;

namespace otros
{
    class Program
    {
        // VERSION MATEMATICA: 
        public static long Invierte_numero_M(long num) {
            long numOriginal = num;
            long residuo, numeroInvertido= 0;
            
            // Termina cuando la division por 10 de originalNumber se trunque 0
            while (numOriginal> 0)
            {
                // Para aislar la ultima cifra del numero.
                residuo = numOriginal % 10;
                // Multiplica el numero del ciclo anterior por 10 (para subirlo una cifra) y le suma el ultimo numero.
                numeroInvertido = numeroInvertido * 10 + residuo;
                // Corta la ultima cifra del numero fuente (al dividir por 10 se hace decimal y se trunca) para que en el siguien ciclo se usa la otra cifra.
                numOriginal /= 10;
            }
            return numeroInvertido;
        }

        //VERSION NO MATEMATICA: 
        public static void Invierte_numero_NM(long num)
        {
            string numTemp= Convert.ToString(num);
            char[] Lista = new char[numTemp.Length];
            int contador = numTemp.Length-1;
            // Bucle que recorre caracteres de numero original y los añade al array empezando por el ultimo lugar.
            foreach(char i in numTemp)
            {
                Lista[contador]= i;
                contador--;
            }
            Console.WriteLine(Lista);
        }
    }
}