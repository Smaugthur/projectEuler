using System;
using System.Diagnostics;
using System.Text;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stopwatch stopWatch = new Stopwatch();
            // stopWatch.Start();
            // stopWatch.Stop(); 
			// Console.WriteLine(stopWatch.Elapsed.ToString());
			var numero = new StringBuilder("123456789");
			int producto = 0;
			for(int i = 0; i<numero.Length; i++){
				producto *= Convert.ToInt32(numero[i]);
			}
			Console.WriteLine(producto);
			Console.WriteLine(numero[3]);

		}
    }
}
