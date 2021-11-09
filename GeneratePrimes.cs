using System;

namespace Activity5._2._1
{
    class GeneratePrimes
    {
        Random r;
        public GeneratePrimes()
        {
            r = new Random();
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
            //ToDo
        }

        public void Prime(int n)
        {
            //ToDo
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