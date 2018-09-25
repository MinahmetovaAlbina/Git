using System;

namespace Rectangles
{
    public static class RectanglesTask
    {
        // Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
        public static bool AreIntersected(Rectangle r1, Rectangle r2)
        {
            // так можно обратиться к координатам левого верхнего угла первого прямоугольника: r1.Left, r1.Top
            return (r1.Left <= r2.Right) && (r2.Left <= r1.Right) && (r1.Top <= r2.Bottom) && (r2.Top <= r1.Bottom);
        }

        // Площадь пересечения прямоугольников
        public static int IntersectionSquare(Rectangle r1, Rectangle r2)
        {
            if (AreIntersected(r1, r2))
            {
                var intersectionWidth = Math.Min(r1.Right, r2.Right) - Math.Max(r1.Left, r2.Left);
                var intersectionHeight = Math.Min(r1.Bottom, r2.Bottom) - Math.Max(r1.Top, r2.Top);
                return intersectionWidth * intersectionHeight;
            }
            else return 0;
        }

        /// <summary>
        /// проверяет вложен ли первый прямоугольник во второй
        /// </summary>
        /// <param name="r1">первый прямоугольник</param>
        /// <param name="r2">второй прямоугольник</param>
        /// <returns>true если да, иначе false</returns>
        public static bool IsItInnerRectangle(Rectangle r1, Rectangle r2)
        {
            return (r1.Right <= r2.Right) && (r1.Left >= r2.Left) && (r1.Top >= r2.Top) && (r1.Bottom <= r2.Bottom);
        }

        // Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
        // Иначе вернуть -1
        // Если прямоугольники совпадают, можно вернуть номер любого из них.
        public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
        {
            if (IsItInnerRectangle(r1, r2))
                return 0;
            else if (IsItInnerRectangle(r2, r1))
                return 1;
            else return -1;
        }
    }
}