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
			ejercicio8.Program.test();	
            stopWatch.Stop(); 
			Console.WriteLine(stopWatch.Elapsed.ToString());
			
/*            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();
			ejercicio8.Program.test();
            stopWatch2.Stop(); 
			Console.WriteLine(stopWatch2.Elapsed.ToString());
			*/
		}
    }
}
