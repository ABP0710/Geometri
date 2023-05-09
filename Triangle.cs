using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Triangle : Rektangel
    {
        private double hypotenuse;

        public Triangle(double a, double b) : base(a, b)
        { 
        
        }

        public override void Area()
        {
            double area = 0.5 * A *B;

            Console.WriteLine("Area of the triangle is " + area);
        }

        public override void Perimeter()
        {
            Pytagoras();

            double perimeter = A+B+hypotenuse;

            Console.WriteLine("Perimeter on the triangle is " + perimeter);
        }

        private void Pytagoras()
        {     
            hypotenuse = Math.Sqrt(A*A+B*B);
        }
    }
}
