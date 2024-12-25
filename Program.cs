using ClassLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        Point3D P = new Point3D(10, 10, 10);
        Console.WriteLine(P.ToString());

        Point3D[] points = new Point3D[3];

        points[0] = new Point3D(10, 10, 10);
        points[0] = new Point3D(5, 5, 5);
        points[0] = new Point3D(15, 15, 15);


        Point3D point1 = new Point3D();
        Point3D point2 = new Point3D();

        Console.WriteLine("enter the first point");
        Point3D.EnterPointCoord_TryParse(point1);
        Console.WriteLine("enter the second point");
        Point3D.EnterPointCoord_TryParse(point2);


        if (point1 == point2)
        {
            Console.WriteLine("Point1 = Point2");
        }
        else {
            Console.WriteLine("point1 != Point2");
        }

        int firstNumber = 10;
        int secondNumber = 20;

        int sumReslut = MathX.Sum(firstNumber, secondNumber);
        Console.WriteLine($"sum Result :{sumReslut}");
        int SubReslut = MathX.Sub(firstNumber, secondNumber);
        Console.WriteLine($"Sub Result :{SubReslut}");
        int mulResult = MathX.Mul(firstNumber, secondNumber);
        Console.WriteLine($"Mul Result :{mulResult}");
        int DivResult = MathX.Div(firstNumber, secondNumber);
        Console.WriteLine($"Div Result :{DivResult}");


        Array.Sort( points );
        foreach (Point3D point in points) {
            Console.WriteLine(point);
        }

        Duration duration = new Duration(1,20,30);
        Console.WriteLine(duration.ToString());
        Duration duration2 = new Duration(3600);
        Console.WriteLine(duration2.ToString());

        DateTime Obj = (DateTime) duration;


    }


}