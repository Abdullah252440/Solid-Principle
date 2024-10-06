using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidprinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            I2DInterface circle = new Circle(5);
            CalculateArea(circle);
            Print.show(circle);
            I2DInterface circle1 = new Rectangle(10, 10);
            CalculateArea(circle1);
            Print.show(circle1);
            I2DInterface circle2 = new Square { Side = 2};
            CalculateArea(circle2);
            Print.show(circle2);
            I3DInterface circle3 = new Cube { Side = 3};
            CalculateVolume(circle3);
            Print.show(circle3);
           
            Console.ReadKey();


        }

       

        
        
        private static void CalculateArea(I2DInterface i2DInterface)
        {
            Console.WriteLine(i2DInterface.GetArea());
        }
        private static void CalculateVolume(I3DInterface i2DInterface)
        {
            Console.WriteLine(i2DInterface.GetVolume());
        }





    }
}
