using System;
using static System.Math;
namespace ejercicio9
{
	class Program
	{// PROBLEMA: Una terna Pitagórica es un grupo de 3 numeros donde a<b<c que cumplen el Teorema de
	 //			  Pitágoras. Hay una terna Pitagórica donde a+b+c=1000. Encontrar el producto de a,b,c.
    

		// SOLUCIÓN 1: fuerza bruta
        public static int solucion1(int max)
        {
            int c = 0, producto = 0;
            for(int a=1; a<max; a++)
            {
                for (int b=1; b<a; b++)
                {
                    c=max-a-b;
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
        // NOTA: esta solucion solo sirve para ternas primitivas.
        public static int solucion2(int max)
        {
            int m=0, n=1, producto=0; 
            int lim=max/2;
            while(true)
            {
                m=(int) Sqrt(lim+(n*n)/2)-(n/2);
                if(m*(m+n)==lim)
                {
                    Console.WriteLine(m);
                    Console.WriteLine(n);
                    producto= (m*m-n*n) * (2*m*n) * (m*m+n*n);
                    break;  
                }
                n++;
            }
            return producto;
        }
	}
}
