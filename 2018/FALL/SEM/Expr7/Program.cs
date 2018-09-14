//Минахметова Альбина 11-808
//Найти вектор, параллельный прямой. Перпендикулярный прямой. Прямая задана коэффициентами уравнения прямой
using System;

namespace Expr7
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            //parallel vector {x;k*x}
            Console.WriteLine("(1;{0}) - параллельный вектор", k);
            //calculate k for perpendicular vector tg=tg+90 => k = -1/k
            k = -1 / k;
            Console.WriteLine("(1;{0}) - перпендикулярный вектор", k);
        }
    }
}
