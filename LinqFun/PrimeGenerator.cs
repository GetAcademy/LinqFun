using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqFun
{
    class PrimeGenerator
    {
        private readonly List<int> _primes;

        public PrimeGenerator()
        {
            _primes = new List<int>(1000);
        }

        public IEnumerable<int> GetPrimes()
        {
            var n = 2;
            while (true)
            {
                if (IsPrime(n))
                {
                    _primes.Add(n);
                    yield return n;
                }
                n++;
            }
        }

        private bool IsPrime(int number)
        {
            return _primes.All(prime => number % prime != 0);
            //foreach (var prime in _primes)
            //{
            //    if (number % prime == 0) return false;
            //}
            //return true;
        }
    }
}
