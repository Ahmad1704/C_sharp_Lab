namespace ClassLibrary
{
    public class Point2D
    {
        public int X { get; set; } 
        public int Y { get; set; }

        public Point2D()
        {
            X = 0;
            Y = 0;
        }
        public Point2D(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }

        public static bool operator == (Point2D left, Point2D right)
        {
            return left.X == right.X && left.Y == right.Y;
        }

        public static bool operator != (Point2D left, Point2D right)
        {
            return left.X != right.X || left.Y != right.Y;
        }





    }
}
