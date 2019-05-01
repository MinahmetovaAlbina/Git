using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    class MidSquareHash : IHasher
    {
        public int Hash(string str, int frame)
        {
            var ten = 10;
            var ch = 1; while (frame < ten)
            {
                ten *= 10;
                ch++;
            }
            var result = new PolynomialHash().Hash(str, frame);
            result *= result;
            while (result < ten)
            {
                ten *= 10;
                ch++;
            }
            ten = 10;
            var pow = ch / 2 - 1;
            for (var i = 0; i < pow; i++)
                ten *= 10;
            result /= ten;
            result %= 1000;
            return result % frame;
        }
    }
}
