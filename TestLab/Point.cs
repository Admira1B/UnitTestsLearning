using System;

namespace TestLab
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public string Name { get; }

        public Point(double x, double y, string name)
        {
            X = x; 
            Y = y;
            Name = name;
        }

        public string DistanceToX(Point point)
        {
            if (Math.Abs(point.X) > Math.Abs(X))
            {
                return $"{Name} ближе к оси X";
            }
            else if (Math.Abs(point.X) < Math.Abs(X))
            {
                return $"{point.Name} ближе к оси X";
            }
            return "Расстояние точек до оси X равно!";
        }

        public string DistanceToY(Point point)
        {
            if (Math.Abs(point.Y) > Math.Abs(Y))
            {
                return $"{Name} ближе к оси Y";
            }
            else if (Math.Abs(point.Y) < Math.Abs(Y))
            {
                return $"{point.Name} ближе к оси Y";
            }
            return "Расстояние точек до оси Y равно!";
        }

        public double DistanceToPoint(Point point)
        {
            double result = Math.Sqrt(Math.Pow(point.X - X, 2) + Math.Pow(point.Y - Y, 2));

            return Math.Abs(result);
        }
    }
}
