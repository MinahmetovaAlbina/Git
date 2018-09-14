//Минахметова Альбина 11-808
//Поменять местами значения двух переменных без промежуточной  переменной
using System;

namespace Expr1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            secondNum -= firstNum;
            firstNum += secondNum;
            secondNum = firstNum - secondNum;
            Console.WriteLine(firstNum);
            Console.WriteLine(secondNum);
        }
    }
}
