using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Square : Shape
    {
        private double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public Square(double A)
        {
            this.A = A;
        }

        public override void Perimeter()
        {
            double perimeter = 4 * a;
            Console.WriteLine("Perimeter on the square = " + perimeter);
        }

        public override void Area()
        {
            double area = a*a;
            Console.WriteLine("Area of the square is = " + area);
        }
    }
}
