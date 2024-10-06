using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidprinciple
{
    public interface ICircle
    {
       
    }
    public interface I2DInterface : ICircle
    {
        double GetArea();
    }
    public interface I3DInterface : ICircle
    {
        double GetVolume();
    }

    public class Circle : I2DInterface
    {

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; set; }
        public double GetArea()
        {
            return Math.PI * Radius * Radius;

        }
    }
    public class Rectangle : I2DInterface
    {
        public Rectangle(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }
        public  double Length { get; set; }
        public double Breadth { get; set; }

        public double GetArea()
        {
            return Length * Breadth;
        }


    }
    public class Square : I2DInterface
    {
        public int Side { get; set; }
        public double GetArea()
        {
            return Side * Side;
        }
    }
    public class Cube : I3DInterface
    {
        public int Side { get; set; }

        public double GetVolume()
        {
            return (Side * Side) * Side;
        }
    }
}

