using System;
using System.Collections.Generic;

namespace Activity5._2._1
{
    class GeneratePrimes
    {
        private Random r;
        public GeneratePrimes()
        {
            this.r = new Random((int)DateTime.Now.Ticks);
        }
        private bool IsPrime(int n)
        {
            for(int i = 2; i < n; i++)
            {
                if(n % i == 0)
                    return false;
            }
            return true;
        }
        public void Prime()
        {
            int m;
            do{
                m = this.r.Next(2,10000);
            }while(!IsPrime(m));
            Console.WriteLine($"Random Prime: {m}");
        }

        public void Prime(int n)
        {
            int m;
            Console.WriteLine($"{n} Random Primes: ");
            for(int i = 1; i <= n; i++)
            {
                do{
                  m = this.r.Next(2,10000);
                }while(!IsPrime(m));
                Console.Write($"{m} ");
            }
        }
        public void Prime(int a, int b)
        {
            Console.WriteLine($"All primes in the range {a} and {b}: ");
            for(int i = a; i <= b; i++)
            {
                if(IsPrime(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }
        public void Prime(int c, int a, int b)
        {
           List<int> pList = new List<int>();
           
           for(int j = a; j <= b; j++)
           {
                if(IsPrime(j))
                {
                    pList.Add(j);
                }
           }
            if(pList.Count < c)
            {
                Console.WriteLine($"There are only {pList.Count} primes in the range {a} to {b}: ");
                foreach(int prime in pList)
                {
                    Console.Write($"{prime} ");
                }
            }
            else
            {
                Console.WriteLine($"First {c} primes in the range {a} to {b}: ");
                for(int i = 0; i < c; i++)
                {
                    Console.Write($"{pList[i]} ");
                }
            }
        }
    }
}