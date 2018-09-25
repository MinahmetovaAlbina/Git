//Минахметова Альбина
//Пролезет ли брус со сторонами x, y, z в отверстие со сторонами a, b, если его разрешается поворачивать на 90 градусов?
using System;

namespace Cond2
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            var z = int.Parse(Console.ReadLine());
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            int count = 0;
            var MaxAB = Math.Max(a, b);

            //если хотя бы два из них не больше максимума среди a и b, то true
            if (x <= MaxAB) count++;
            if (y <= MaxAB) count++;
            if (z <= MaxAB) count++;
            //если хотя бы один из них не больше минимума среди a и b, то true
            var answer = (Math.Min(x, Math.Min(y,z)) <= Math.Min(a, b));
            //объединяем условия
            answer = answer && (count > 1);
            Console.WriteLine(answer);
        }
    }
}
