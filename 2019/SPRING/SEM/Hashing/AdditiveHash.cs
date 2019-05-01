using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    class AdditiveHash : IHasher
    {
        public int Hash(string str, int frame)
        {
            var result = 0;
            foreach (var c in str)
                result += c;
            return result % frame;
        }
    }
}
