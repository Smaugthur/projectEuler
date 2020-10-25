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
            Console.WriteLine(ejercicio5.Program.minimoComuMultiplo());
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed.ToString());
        }
    }
}