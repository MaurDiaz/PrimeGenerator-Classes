using System;

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
            int n;
            do{
                n = this.r.Next(2,1000);
            }while(!IsPrime(n));
            Console.WriteLine($"Random Prime: {n}");
        }

        public void Prime(int n)
        {
            int m;
            Console.WriteLine($"{n} Random Primes: ");
            for(int i = 1; i <= n; i++)
            {
                do{
                  m = this.r.Next(2,1000);
                }while(!IsPrime(m));
                Console.Write($"{m} ");
            }
        }
        public void Prime(int a, int b)
        {
            //ToDo
        }
        public void Prime(int c, int a, int b)
        {
           //ToDo
        }
    }
}