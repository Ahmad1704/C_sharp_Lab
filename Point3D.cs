using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Point3D : IComparable, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D() 
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Point3D(int _X, int _Y, int _Z)
        {
            X = _X;
            Y = _Y;
            Z = _Z;
        }

       
        public Point3D(Point3D p) : this(p.X, p.Y, p.Z)
        {
        }
        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        }

        public static explicit operator string(Point3D p)
        {
            return $"({p.X},{p.Y},{p.Z})";
        }

        public static void EnterPointCoord_parse(Point3D point)
        {
            Console.WriteLine($"Enter X Coord");
            point.X = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter Y Coord");
            point.Y = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter Z Coord");
            point.Z = int.Parse(Console.ReadLine());

        }
        public static void EnterPointCoord_TryParse(Point3D point)
        {
            int tempX;
            int tempY;
            int tempZ;
            Console.WriteLine("Enter X Coord:");
            while (!int.TryParse(Console.ReadLine(), out tempX))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for X:");
            }
            point.X = tempX;
            Console.WriteLine("Enter Y Coord:");
            while (!int.TryParse(Console.ReadLine(), out tempY))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for Y:");
            }
            point.Y = tempY;
            Console.WriteLine("Enter Z Coord:");
            while (!int.TryParse(Console.ReadLine(), out tempZ))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for Z:");
            }
            point.Y = tempZ;
        }

        public static void EnterPointCoord_Convert(Point3D point)
        {
            Console.WriteLine("Enter X Coord:");
            bool validX = false;
            while (!validX)
            {
                try
                {
                    point.X = Convert.ToInt32(Console.ReadLine());
                    validX = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for X:");
                }
            }

            Console.WriteLine("Enter Y Coord:");
            bool validY = false;
            while (!validY)
            {
                try
                {
                    point.Y = Convert.ToInt32(Console.ReadLine());
                    validY = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for Y:");
                }
            }
            Console.WriteLine("Enter Z Coord:");
            bool validZ = false;
            while (!validZ)
            {
                try
                {
                    point.Z = Convert.ToInt32(Console.ReadLine());
                    validZ = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for Z:");
                }
            }
        }

        public static bool operator ==(Point3D left, Point3D right)
        {
            return left.X == right.X && left.Y == right.Y;
        }

        public static bool operator !=(Point3D left, Point3D right)
        {
            return left.X != right.X || left.Y != right.Y;
        }

        public object Clone()
        {
            return new Point3D(this.X, this.Y, this.Z);
        }

        public int CompareTo(object? obj)
        {
            Point3D? point = obj as Point3D;
            if (point == null)
                throw new ArgumentException("Object is not an Point3D");

            if (X > point.X)
                return 1;
            else if (X < point.X)
                return -1;
            if (Y > point.Y)
                return 1;
            else if (Y < point.Y)
                return -1;
            return 0;
        }
    }
}