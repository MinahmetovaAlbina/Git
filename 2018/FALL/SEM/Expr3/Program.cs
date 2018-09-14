//Минахметова Альбина 
//Задано время Н часов (ровно). Вычислить угол в градусах между часовой и минутной стрелками
using System;

namespace hourToDeg
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            // transform hour to deg
            hour = 180 - Math.Abs(hour % 12 * 30 - 180);
            Console.WriteLine(hour);
        }
    }
}
