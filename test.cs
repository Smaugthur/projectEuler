using System;
using System.Diagnostics;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch time= new Stopwatch(); 
            time.Start();
            Console.WriteLine(ejercicio4.Program.MiSolucion());
            time.Stop();
            Console.WriteLine(time.Elapsed.ToString());
        }
    }
}