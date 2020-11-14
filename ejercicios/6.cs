namespace ejercicio6
{
    class Program
    {// PROBLEMA: Encontrar la diferencia del cuadrado de la suma de los terminos del 1 al 100 menos la suma de los cuadrados del 1 al 100.
        public static long cuadradoDiferencia(int numMax)
        {
            int minuendo = 0; 
            int sustraendo = 0;
            minuendo = ejercicio1.Program.solucionOP2(numMax+1,1) * ejercicio1.Program.solucionOP2(numMax+1,1); 

            for(int i = 1; i<=numMax; i++)
            {
                sustraendo += i*i;
            }
            return minuendo - sustraendo;
        }
    }
}

