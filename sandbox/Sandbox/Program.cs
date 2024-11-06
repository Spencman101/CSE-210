using System;
using System.Runtime.CompilerServices;
using System.Media;

class Program
{
    class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            // Console.WriteLine("In the constructor");
            this.radius = radius;
        }
        
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
        public double GetDiameter()
        {
            return 2 * radius;
        }
        public double GetCircumference()
        {
            return Math.PI * 2 * radius;
        }
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public void Display()
        {
            Console.WriteLine($"Area is: {GetArea()}");
            Console.WriteLine($"Radius is: {GetRadius()}");
            Console.WriteLine($"Diameter is: {GetDiameter()}");
            Console.WriteLine($"Radius is: {GetRadius()}");
        }
    }

    static void Main(string[] args)
    {

        // Console.WriteLine("Bonjour mes amis, comment ca va?");

        int x = 10;
        // First is the class/datatype, then is the variable name/object, new is a keyword to create a new version of the object, then lastly is the constructor caller/type of object.
        Circle MyCircle = new Circle(x);
        Circle MyCircle2 = new Circle(x + 10);
        
        MyCircle.Display();
        MyCircle.SetRadius(x + 100);
        MyCircle.Display();

        // Does not work because Radius is private
        // MyCircle.radius = 10;

        // Console.WriteLine(MyCircle.GetArea());
        // Console.WriteLine(MyCircle2.GetArea());

        // Console.WriteLine(MyCircle.GetCircumference());
        // Console.WriteLine(MyCircle.GetDiameter());
        // Console.WriteLine(MyCircle.GetRadius());
        
    }
}