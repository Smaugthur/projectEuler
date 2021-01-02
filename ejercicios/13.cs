using System;
using System.IO;
using System.Numerics;

namespace ejercicio13
{ // PROBLEMA: Suma los 50 numeros del fichero "/src/tex_ej_13" y escribe las primeras 10 cifras del resultado.
    class Program
    {
        // SOLUCION 1: Uso del tipo "BigInteger" para guardar numeros grandes.
        public static void solucion1()
        {
            BigInteger suma = new BigInteger(); 
            TextReader r =new StreamReader("./src/tex_ej_13.txt");
            string linea;

            while ((linea=r.ReadLine()) != null)
            {
                suma+=BigInteger.Parse(linea);
            }
            r.Close();

            Console.WriteLine(suma);
        }
    }
}
