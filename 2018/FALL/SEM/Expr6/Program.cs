//Минахметова Альбина 11-808
//Посчитать расстояние от точки до прямой, заданной двумя разными точками.
using System;

namespace Expr6
{
    class Program
    {
        /// <summary>
        /// Calculates length of the line segment AB: A(x1;y1), B(x2;y2)
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        static double Length(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        static void Main(string[] args)
        {
            //the line describe with two point A(x1;y1) and B(x2;y2)
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            ////the Point C(x0;y0)
            var x0 = double.Parse(Console.ReadLine());
            var y0 = double.Parse(Console.ReadLine());
            //b = AC
            var b = Length(x1, y1, x0, y0);
            //a = BC
            var a = Length(x2, y2, x0, y0);
            //c = AB
            var c = Length(x1, y1, x2, y2);
            //calculate length from the point to the line
            var h = Math.Sqrt((b * b + a * a - (c * c + (b * b - a * a) * (b * b - a * a) / (c * c)) / 2) / 2);
            Console.WriteLine(h);
        }
    }
}
