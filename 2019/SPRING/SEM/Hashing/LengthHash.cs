using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    class LengthHash : IHasher
    {
        public int Hash(string str, int frame)
        {
            return str.Length % frame;
        }
    }
}
