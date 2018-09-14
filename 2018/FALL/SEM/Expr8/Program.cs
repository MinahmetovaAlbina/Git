//Минахметова Альбина 11-808
// Дана прямая L и точка A. Найти точку пересечения прямой L с перпендикулярной ей прямой P, проходящей через точку A
using System;


namespace Exp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //The line describe y=k*x+b
            var k = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            //The point A describe (xa;ya)
            var xa = double.Parse(Console.ReadLine());
            var ya = double.Parse(Console.ReadLine());
            //calculate x of new point
            var x = (ya + xa / k - b) / (k + 1 / k);
            //calculate y of new point
            var y = k * x + b;
            Console.WriteLine("({0};{1})", x, y);
        }
    }
}
