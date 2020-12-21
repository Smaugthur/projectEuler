namespace ejercicio6
{
    class Program
    {// PROBLEMA: Encontrar la diferencia del cuadrado de la suma de los terminos del
     //           1 al 100 y la suma de los cuadrados del 1 al 100:
     //           (S)^2 - (S^2) 

        // SOLUCION : usando formulas de suma de Series.
        public static long cuadradoDiferencia(int numMax)
        {
            int minuendo = 0; 
            int sustraendo = 0;
            minuendo = (numMax/1) * (numMax+1)/2;
            sustraendo = (numMax * (numMax + 1) * (2 * numMax + 1)) / 6;
            return minuendo*minuendo - sustraendo;
        }
    }
}

