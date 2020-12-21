using System;

namespace ejercicio4
{
    class Program
    {// PROBLEMA: el numero palidromo más largo producto de 2 números de 3 cifras.

        // SOLUCION 1: encontrar el mayor palindromo y luego encontrar sus factores
		public static void solucion1()
		{
            long Palindromo = 0;
            long factor1 = 0;
            long factor2 = 0;
			// ! Empezamos desde el maximo y descendemos.
            for(long i = 998001; i>11111 ;i--)
            {
                if(i == otros.Program.Invierte_numero_M(i))
                {
                    for(long e = 100; e<1000; e++)
                    {
                        if(i%e == 0)
                        {
                            long tempNum = i/e;
                            if(tempNum > 99 && tempNum < 1000)
                            {
								factor1=e;
								factor2=tempNum;
                                Palindromo = i;
								break;
                            }
                        }
                    }
					if(Palindromo != 0)
						break;
                }
            }
            Console.WriteLine($"Palindromo: {Palindromo}\nfactor 1: {factor1}\nfactor 2: {factor2}");
		}

        //SOLUCION 2: encontrar el mayor palindromo y luego sus factores.
        public static void solucion2()
        {
            long Palindromo = 0;
            long factor1 = 0;
            long factor2 = 0;
			// ! Empezamos desde el minimo y aumentamos.
            for(long i = 11111; i<998001;i++)
            {
                if(i == otros.Program.Invierte_numero_M(i))
                {
                    for(long e = 100; e<1000; e++)
                    {
                        if(i%e == 0)
                        {
                            long tempNum = i/e;
                            if(tempNum > 99 && tempNum < 1000)
                            {
								factor1=e;
								factor2=tempNum;
                                Palindromo = i;
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Palindromo: {Palindromo}\nfactor 1: {factor1}\nfactor 2: {factor2}");
        }
    }
}
