using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LinqFun
{
    class NumberSequenceEnumerator : IEnumerator<int>
    {
        private int _n;


        public bool MoveNext()
        {
            _n++;
            Console.WriteLine("Moving next to " + _n);
            Thread.Sleep(5000);
            return _n < 10;
        }

        public void Reset()
        {
            _n = 1;
        }

        public int Current => _n;

        object? IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}
