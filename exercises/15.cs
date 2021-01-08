using System;

namespace exercise15
{// PROBLEM: Find all the possible paths to reach the bottom right corner starting from 
 //          the top left corner in a 20x20 grid. Only being able to move to the right and down.

    class Program
    {
        /* SOLUTION 1: Dynamic programming
        *             The idea behind the solution is to calculate all the possible paths
        *             that emerge from any single point of the grid to the goal; starting 
        *             from the ones that are adyacent to the goal. 
        *
        *             Every point will have an attached value that provides the No. of paths
        *             that can emerge from it to the goal.
        *             
        *             This way, we can get the number of paths that of an unkown point based on
        *             the sum of the No. of paths  from the ones that are adyacent to it. Ex:
        *
        *             x ---- 1    <- How many paths to x has? 2 paths, that correspond to the sum 
        *             |      |       of No. of possible paths that we´ll have if we move 1 step right
        *             1 --- End      or down.
        */
        public static void solution1(int size)
        {
            long[,] grid = new long[size+1 ,size+1];

            for(int i=size; i>=0; i--)
            {
                grid[size,i]=1;
                grid[i,size]=1;
            }
            for(int y=size-1; y>=0;y--)
            {
                for(int x=size-1; x>=0;x--)
                {
                    grid[y,x]= grid[y,x+1] + grid[y+1,x];
                }
            }

            Console.WriteLine(grid[0,0]);
        }

        // SOLUTION 2: Conbinatorics
        //             Using the "Binomial Coefficients" or "combinatorial numbers":
        //             ∏i=k n-i/i
        public static void solution2(int size)
        {
            long paths=1;
            for(int i=0;i<size;i++)
            {
                paths*=(2*size)-i;
                paths/=i+1;
            }
            Console.WriteLine(paths);
        }
    }
}
