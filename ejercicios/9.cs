using System;

namespace ejercicio9
{
	class Program
	{// PROBLEMA: Una terna Pitagórica es un grupo de 3 numeros donde a<b<c que cumplen el Teorema de
	 //			  Pitágoras. Hay una terna Pitagórica donde a+b+c=1000. Encontrar el producto de a,b,c.

		// SOLUCIÓN 1: fuerza bruta
        public static int TernaPitagorica (int max)
        {
            int c = 0, producto = 0;
            for(int a=1; a<1000; a++)
            {
                for (int b=1; b<a; b++)
                {
                    c=1000-a-b;
	                if(a*a+b*b == c*c)
                    {
                        producto=a*b*c;
                        Console.WriteLine("a="+a+" b="+b+" c="+c);
                        break;
                    }
                }
            }
            return producto;
        }

        // SOLUCIÓN 2: método Euclideo
        /*public staic int TernaPitagorica2 ()
        {
           
        }*/
	}
}
