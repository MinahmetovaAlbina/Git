//Минахметова Альбина 11-808
//рефакторинг кода
using System;
using System.Diagnostics;
using System.Drawing;

namespace RefactorMe
{
    class Risovatel
    {
        static Bitmap image = new Bitmap(800, 600);
        static float x, y;
        static Graphics graphics;

        public static void Initialize()
        {
            image = new Bitmap(800, 600);
            graphics = Graphics.FromImage(image);
        }

        public static void SetPos(float x0, float y0)
        {
            x = x0;
            y = y0;
        }

        public static void Go(double length, double angle)
        {
            //Делает шаг длиной L в направлении angle и рисует пройденную траекторию
            var x1 = (float)(x + length * Math.Cos(angle));
            var y1 = (float)(y + length * Math.Sin(angle));
            graphics.DrawLine(Pens.Yellow, x, y, x1, y1);
            x = x1;
            y = y1;
        }

        public static void ShowResult()
        {
            image.Save("result.bmp");
            Process.Start("result.bmp");
        }
    }

    public class StrangeThing
    {
        static double Length = 100;
        static double Width = 10;
        static double Num = 4;

        /// <summary>
        /// рисует одну часть невозможного квадрата
        /// </summary>
        /// <param name="x0">начальная координата x</param>
        /// <param name="y0">начальная координата Y</param>
        /// <param name="angle">угол направления части</param>
        static void DrowPart(double x0, double y0, double angle)
        {
            Risovatel.SetPos((float)x0, (float)y0);
            Risovatel.Go(Length, angle);
            Risovatel.Go(Width * Math.Sqrt(2),angle + Math.PI / 4);
            Risovatel.Go(Length, angle + Math.PI);
            Risovatel.Go(Length - Width, angle + 2 * Math.PI / Num);
        }
        public static void Main()
        {
            Risovatel.Initialize();

            //рисует первую часть
            StrangeThing.DrowPart(Width, 0, 0);
            //рисует вторую часть
            StrangeThing.DrowPart(Length + 2 * Width, Width, 2* Math.PI / Num);
            //рисует третью часть
            StrangeThing.DrowPart(Length + Width, Length + 2 * Width, 4 * Math.PI / Num);
            //рисует четвёртую часть
            StrangeThing.DrowPart(0, Length + Width, 6 * Math.PI / Num);

            Risovatel.ShowResult();
        }
    }
}
