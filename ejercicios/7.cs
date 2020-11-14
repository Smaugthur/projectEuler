using System;

namespace ejercicio7
{
    class Program
    {
		public static long devuelveNthPrimo(int numeroMax) {
			
			long primo=2;
			int contador=1;
			bool esPrimo=true;
			for(int i = 3; contador<numeroMax; i++){
				for(int e=2; e*e<=i ; e++){
					if(i%e==0){
						esPrimo=false;
						break;
					}
				}
				if(esPrimo){
					primo=i;
					contador++;
				}
				esPrimo=true;
			}
			return primo;
		}
    }
}
