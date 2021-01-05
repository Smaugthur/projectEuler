using System;

namespace exercise7
{// PROBLEM:  find the 10,001 prime starting from 2.

    // SOLUTION: Brute force 
    class Program
    {
		public static long solution(int numMax) {
			
			long prime=2;
			int count=1;
			bool isPrime=true;
			for(int i = 3; count<numMax; i+=2){
				for(int e=2; e*e<=i ; e++){
					if(i%e==0){
						isPrime=false;
						break;
					}
				}
				if(isPrime){
					prime=i;
					count++;
				}
				isPrime=true;
			}
			return prime;
		}
    }
}
