using System;

namespace ejercicio7
{// PROBLEMA: encontrar el numero primo 10,001 empezando desde 2.

    // SOLUCION: fuerza bruta
    class Program
    {
		public static long solucion(int numeroMax) {
			
			long primo=2;
			int contador=1;
			bool esPrimo=true;
			for(int i = 3; contador<numeroMax; i+=2){
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
