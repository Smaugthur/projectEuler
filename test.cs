using System;
using System.Diagnostics;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
			ejercicio4.Program.MiSolucion();
            stopWatch.Stop(); 
			Console.WriteLine(stopWatch.Elapsed.ToString());
        }
    }
}
