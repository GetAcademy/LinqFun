using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinqFun
{
    class NumberSequence : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new NumberSequenceEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
