using System;
using System.Diagnostics;
using static System.Console;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            //WriteLine(ejercicio10.Program.solucion1(2000000));
            WriteLine(ejercicio10.Program.solucion2(2000000));
            stopWatch.Stop(); 
            Console.WriteLine(stopWatch.Elapsed.ToString());
        }
    }
}

