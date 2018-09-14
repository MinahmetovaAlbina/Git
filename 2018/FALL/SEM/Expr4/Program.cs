//Минахметова Альбина 11-808
//Найти количество чисел меньших N, которые имеют простые делители X или Y
using System;

namespace Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var X = int.Parse(Console.ReadLine());
            var Y = int.Parse(Console.ReadLine());
            Console.WriteLine((N - 1) / X + (N - 1) / Y + (N - 1) / (X * Y));
        }
    }
}
