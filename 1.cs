using System;
using System.Diagnostics;

namespace variables
{
    class Program
    {  
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int numeroMax;

            Console.WriteLine("¿Hasta que número quieres fijar el límite?");
            numeroMax = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa primer número:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa segundo número:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(muestraSuma(numeroMax,num1,num2));

        }

        static int muestraSuma (int numeroMax, int num1, int num2)
        {
            int sumaPrimerNumero1 = sumaMultiplos(numeroMax,num1);
            int sumaSegundoNumero2 =sumaMultiplos(numeroMax,num2);

            int sumaTotal = sumaPrimerNumero1 + sumaSegundoNumero2;

            return sumaTotal;
        }

        static int sumaMultiplos (int numeroMax, int numerobase)
        {
            int multiplo = 0;
            int sumaMultiplos = 0;
            int i = 1;

            while(multiplo<numeroMax)
            {
                // Para obtener un multiplo multiplicamos el número base por otros numero (i).
                multiplo = numerobase*i;
                // Cada multiplo nuevo de la operación anterior se suman en sumaMultiplos.
                sumaMultiplos += multiplo;
                i++;
                // Para asegurar que el siguiente multiplo sea menor el numeroMax, y no entre en el ciclo.
                multiplo = numerobase*i;
            }

            return sumaMultiplos;
        }
    }
}