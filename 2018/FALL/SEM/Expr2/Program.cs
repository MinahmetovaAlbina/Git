/*Минахметова Альбина 11-808
Задается натуральное трехзначное число (гарантируется, что трехзначное)
Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке*/
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            //the first numeral of new number
            var num1 = num % 10;
            //the second numeral of new number
            var num2 = num / 10 % 10;
            //the third numeral of new number
            var num3 = num / 100;
            //calculate new number
            num = num3 + num2 * 10 + num1 * 100;
            Console.WriteLine(num);
        }
    }
}