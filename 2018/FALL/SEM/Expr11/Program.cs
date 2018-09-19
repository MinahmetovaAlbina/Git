//Минахметова Альбина
//Дано время в часах и минутах. Найти угол от часовой к минутной стрелке на обычных часах
using System;

namespace Expr11
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var part = str.Split(':');
            var minutes = double.Parse(part[1]);
            //переводим часы в минуты и прибавляем минуты, для нахождения положения часовой стрелки
            var hourInMinutes = double.Parse(part[0]) % 12 * 60 + minutes;
            //из угла образованного с 12 часами минутной стрелкой вычитаем угол, образованный часовой стрелкой
            Console.WriteLine(Math.Abs(minutes * 6 - hourInMinutes / 2));
        }
    }
}
