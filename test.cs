using System;
using System.Diagnostics;
using System.Text;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine(ejercicio9.Program.solucion2(60));
            stopWatch.Stop(); 
            Console.WriteLine(stopWatch.Elapsed.ToString());
            //Console.WriteLine(ejercicio9.Program.solucion1(1000));
		}
    }
}

