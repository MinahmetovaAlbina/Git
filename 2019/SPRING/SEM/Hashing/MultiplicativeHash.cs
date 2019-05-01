using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    class MultiplicativeHash : IHasher
    {
        private readonly double A = (Math.Sqrt(5) - 1) / 2;
        public int Hash(string str, int frame)
        {
            var result = (double)new PolynomialHash().Hash(str, frame);
            result = result * A;
            result = result % 1;
            result *= frame;
            return (int)result;
        }
    }
}
