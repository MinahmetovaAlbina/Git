using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace JarvisMarch
{
    class Data
    {
        //создаёт файл и заполняет его псевдослучайными точками со значениями от 0 до maxValue и округлёнными до powE
        public static void FillFile(int maxValue, int powE)
        {
            var random = new Random();
            var text = new string[100];
            for (var i = 0; i < text.Length; i++)
            {
                var points = new HashSet<Point>();
                var pointsString = new StringBuilder();
                var maxCount = 100 * (i + 1);
                var pointsCount = 0;
                while (pointsCount < maxCount)
                {
                    var x = Math.Round(maxValue * random.NextDouble(), powE);
                    var y = Math.Round(maxValue * random.NextDouble(), powE);
                    var p = new Point(x, y);
                    if (points.Contains(p)) break;
                    points.Add(p);
                    pointsString.AppendFormat("{0} {1};", x, y);
                    pointsCount++;
                }
                text[i] = pointsString.ToString();
            }
            File.WriteAllLines("text.txt", text);
        }

        //считывает точки из файла и заполняет ими лист связных списков точек и лист массивов точек
        public static void ConvertTo(out List<LinkedList<Point>> l, out List<Point[]> a)
        {
            var text = File.ReadAllLines("text.txt");
            l = new List<LinkedList<Point>>();
            a = new List<Point[]>();
            foreach (var str in text)
            {
                var pointArr = str.Split(';');
                var arr = new Point[pointArr.Length - 1];
                var linList = new LinkedList<Point>();
                for (var i = 0; i < pointArr.Length - 1; i++)
                {
                    var point = pointArr[i].Split(' ');
                    var x = double.Parse(point[0]);
                    var y = double.Parse(point[1]);
                    var p = new Point(x, y);
                    arr[i] = p;
                    linList.AddLast(p);
                }
                l.Add(linList);
                a.Add(arr);
            }
        }
    }
}
