using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_2
{
    interface GeometricFigure
    {
        double Space { get; }
        string Information();
    }
   

    public class Square : GeometricFigure
    {
        int side;
        int Side { get { return side; }}
        public Square( int side)
        {
            this.side = side;
        }
        public int Perimeter { get { return 4 * side; } }
        public double Space { get { return (side * side); } }

        public string Information()
        {
            return "\t\tSquare\nSide - " + side + "\nSpace - " + Perimeter + "\nSpace - " + Space + "\n";
        }
    }
    public class Circle : GeometricFigure
    {
        int radius;
        string color;
        public int Radius { get { return radius;} }
        public string Color { get { return color; } }
        public Circle(int radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        
        public double Space { get { return Math.PI * radius * radius; } }
        public string Information()
        {
            return "\t\tCircle\nRadius - " + radius + "\nColor - " + color + "\nSpace - " + Space + "\n";
        }
    }

    class ArrayOfFigures : IEnumerable
    {
        string[] geometricFigure;

        public ArrayOfFigures(string[] geometricFigure)
        {
            this.geometricFigure = geometricFigure;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return geometricFigure.GetEnumerator();
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Square sqare1 = new Square(3);
            Square sqare2 = new Square(4);

            Circle circle1 = new Circle(3, "green");
            Circle circle2 = new Circle(4, "blue");

            string[] informFigure =
            {
                sqare1.Information(),
                sqare2.Information(),
                circle1.Information(),
                circle2.Information(),
            };

            ArrayOfFigures array = new ArrayOfFigures(informFigure);
            foreach (string f in informFigure)
                Console.WriteLine(f);
            Console.ReadLine();
        }
    }
}