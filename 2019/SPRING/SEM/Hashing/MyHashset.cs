using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    class MyHashset
    {
        private IHasher hasher;
        private List<string>[] data;
        public int Count { get; private set; }
        public int Frame { get; private set; }

        public MyHashset(IHasher hasher)
        {
            this.hasher = hasher;
            Frame = 1;
            Count = 0;
            data = new List<string>[Frame];
        }

        public bool Add(string item)
        {
            if (Contains(item)) return false;
            Count++;
            if (Count > Frame)
            {
                Frame = (Frame + 3) * 2 - 3;
                var newData = new List<string>[Frame];
                foreach(var list in data)
                    foreach(var s in list)
                    {
                        AddOne(s);
                    }
            }
            AddOne(item);
            return true;
        }

        public bool Contains(string item)
        {
            var hash = hasher.Hash(item, Frame);
            return data[hash].Contains(item);
        }

        public bool Remove(string item)
        {
            if (!Contains(item)) return false;
            var hash = hasher.Hash(item, Frame);
            data[hash].Remove(item);
            return true;
        }

        private void AddOne(string item)
        {
            var hash = hasher.Hash(item, Frame);
            data[hash].Add(item);
        }
    }
}
