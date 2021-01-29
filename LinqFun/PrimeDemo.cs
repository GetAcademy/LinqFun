using System;
using System.Collections.Generic;
using System.Text;

namespace LinqFun
{
    class PrimeDemo
    {
        public static void Run()
        {
            var start = DateTime.Now;
            var primeGenerator = new PrimeGenerator();
            foreach (var p in primeGenerator.GetPrimes())
            {
                if (p > 1000) break;
                //Console.WriteLine(p);
            }

            //for (var n = 2; n < 10000; n++)
            //{
            //    if (IsPrime(n))
            //    {
            //        //Console.WriteLine(n);
            //    }
            //}

            var finish = DateTime.Now;
            var timeSpan = finish-start;
            Console.WriteLine($"{timeSpan.TotalMilliseconds:F2}");
        }

        private static bool IsPrime(int number)
        {
            if (number % 2 == 0) return false;
            for (var factor = 3; factor < Math.Ceiling(Math.Sqrt(number)); factor+=2)
            {
                if (number % factor == 0) return false;
            }
            return true;
        }
    }
}
