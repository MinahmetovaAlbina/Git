//Минахметова Альбина
/*Козла пустили в квадратный огород и привязали к колышку. Колышек воткнули точно в центре огорода.
Козёл ест всё, до чего дотянется, не перелезая через забор огорода и не разрывая веревку.
Какая площадь огорода будет объедена? Даны длина веревки и размеры огорода.*/
using System;

namespace Expr13
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = Console.ReadLine();
            var parts = userInput.Split(' ');
            var sideOgGarden = int.Parse(parts[0]);
            var rope = int.Parse(parts[1]);
            //the area that the goat will eat
            double s;

            if (2 * rope <= sideOgGarden)
                //if the rope shorter than a half side of the garden than the goat will eat the a circle-shaped area
                s = Math.PI * rope * rope;
            else if (2 * rope >= sideOgGarden * sideOgGarden)
                s = sideOgGarden * sideOgGarden;
                //if a half diagonally of the garden shorter than the rope then the goat will eat a square-shaped area
            else
                //else the goat will eat an area of a circle minus an area of its segments
                s = Math.PI * rope * rope - 4 * rope * rope * Math.Acos(sideOgGarden / (2.0 * rope)) + 4 * sideOgGarden * Math.Sqrt(4 * rope * rope - sideOgGarden * sideOgGarden) / (4.0);
            Console.WriteLine(s);
        }
    }
}
