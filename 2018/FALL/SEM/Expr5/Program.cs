//Minahmetova Albina 11-808
//Найти количество високосных лет на отрезке [a, b]
using System;

namespace TheLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine((b / 4 - b / 100 + b / 400) - (a / 4 - a / 100 + a / 400));
        }
    }
}