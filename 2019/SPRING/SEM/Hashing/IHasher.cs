using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    

    interface IHasher
    {
        int Hash(string str, int frame);
    }
}
