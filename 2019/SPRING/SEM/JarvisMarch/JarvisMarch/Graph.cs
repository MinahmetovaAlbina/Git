using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace JarvisMarch
{
    class Graph
    {
        private readonly Form form;
        private readonly ZedGraphControl chart;
        private readonly PointPairList timeListPoints;
        private readonly PointPairList timeArrPoints;
        private readonly PointPairList iterationListPoints;
        private readonly PointPairList iterationArrPoints;
        private readonly PointPairList square;

        public Graph()
        {

            form = new Form
            {
                WindowState = FormWindowState.Maximized
            };

            chart = new ZedGraphControl()
            {
                Dock = DockStyle.Fill
            };

            chart.GraphPane.Title.Text = "TIME";
            //chart.GraphPane.Title.Text = "ITERATIONS";

            chart.GraphPane.Title.FontSpec.FontColor = Color.White;
            chart.GraphPane.Chart.Fill.Brush = new SolidBrush(Color.Black);
            chart.GraphPane.Fill.Color = Color.Black;
            chart.GraphPane.Chart.Border.IsVisible = false;

            chart.GraphPane.XAxis.Title.FontSpec.FontColor = Color.White;
            chart.GraphPane.XAxis.Scale.FontSpec.FontColor = Color.White;
            chart.GraphPane.XAxis.MajorGrid.IsVisible = true;
            chart.GraphPane.XAxis.MajorGrid.Color = Color.White;
            chart.GraphPane.XAxis.Color = Color.White;

            chart.GraphPane.YAxis.Title.FontSpec.FontColor = Color.White;
            chart.GraphPane.YAxis.Scale.FontSpec.FontColor = Color.White;
            chart.GraphPane.YAxis.MajorGrid.IsVisible = true;
            chart.GraphPane.YAxis.MajorGrid.Color = Color.White;
            chart.GraphPane.YAxis.Color = Color.White;

            chart.GraphPane.XAxis.Title.Text = "n";
            chart.GraphPane.YAxis.Title.Text = "t";
            chart.GraphPane.XAxis.Scale.MaxAuto = true;
            chart.GraphPane.XAxis.Scale.MinAuto = true;
            chart.GraphPane.YAxis.Scale.MaxAuto = true;
            chart.GraphPane.YAxis.Scale.MinAuto = true;
            
            timeArrPoints = AddCurve("Array", Color.LightGreen, 3);
            timeListPoints = AddCurve("LinkedList", Color.LightCoral, 3);
            //iterationArrPoints = AddCurve("Array", Color.LightGreen, 3);
            //iterationListPoints = AddCurve("Linked List", Color.LightCoral, 5);
            //square = AddCurve("Quad Function", Color.Cyan, 3);

            chart.GraphPane.Legend.Fill.Brush = new SolidBrush(Color.Black);
            chart.GraphPane.Legend.FontSpec.FontColor = Color.White;
            Data.ConvertTo(out List<LinkedList<Point>> l, out List<Point[]> a);
            FillListPoint(l, a);
            chart.AxisChange();
            form.Controls.Add(chart);
        }

        private PointPairList AddCurve(string label, Color color, int width)
        {
            var curve = new PointPairList();
            var line = chart.GraphPane.AddCurve(label, curve, color, SymbolType.None);
            line.Line.Width = width;
            line.Line.IsAntiAlias = true;
            return curve;
        }

        private void FillListPoint(List<LinkedList<Point>> listPoints, List<Point[]> arrayPoints)
        {
            var watch = new Stopwatch();

            foreach (var list in listPoints)
            {
                var x = list.Count;
                var march = new JarvisMarch();
                var iterations = 0;
                watch.Start();
                march.March(list, ref iterations);
                watch.Stop();

                timeListPoints.Add(x, watch.ElapsedMilliseconds);
                //iterationListPoints.Add(list.Count, iterations);
                //square.Add(x, x * x);

                watch.Reset();
            }

            foreach (var arr in arrayPoints)
            {
                var march = new JarvisMarch();
                var iterations = 0;
                watch.Start();
                march.March(arr, ref iterations);
                watch.Stop();

                timeArrPoints.Add(arr.Length, watch.ElapsedMilliseconds);
                //iterationArrPoints.Add(arr.Length, iterations);

                watch.Reset();
            }
        }

        public void Run()
        {
            Application.Run(form);
        }
    }
}
