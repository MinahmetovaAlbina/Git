using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    class PolynomialHash : IHasher
    {
        private const int k = 101;
        public int Hash(string str, int frame)
        {
            var result = (int)str[0];
            for (var i = 1; i < str.Length; i++)
                result = (result * k + str[i]) % frame;
            return result;
        }
    }
}
