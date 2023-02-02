namespace TestLab
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x; 
            Y = y;
        }

        public string DistanceToX(Point point)
        {
            if (Math.Abs(point.X) >= Math.Abs(X))
            {
                return "Точка 1 ближе к оси X";
            }
            else if (Math.Abs(point.X) < Math.Abs(X))
            {
                return "Точка 2 ближе к оси X";
            }
            return "Расстояние точек до оси X равно!";
        }

        public string DistanceToY(Point point)
        {
            if (Math.Abs(point.Y) >= Math.Abs(Y))
            {
                return "Точка 1 ближе к оси Y";
            }
            else if (Math.Abs(point.Y) < Math.Abs(Y))
            {
                return "Точка 2 ближе к оси Y";
            }
            return "Расстояние точек до оси Y равно!";
        }

        public double DistanceToPoint(Point point)
        {
            double result = Math.Sqrt(Math.Pow(point.X - X, 2) + Math.Pow(point.Y - Y, 2));

            return Math.Abs(result);
        }

        public override string ToString()
        {
            return $"x: {X}\ny: {Y}";
        }
    }
}
