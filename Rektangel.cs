using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Rektangel : Square
    {
        private double b;

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public Rektangel(double a, double b) : base(a)
        {
            this.b = b;
        }

        public override void Perimeter()
        {
            double perimeter = 2*(A+b);

            Console.WriteLine("Perimeter on the rektangel = " + perimeter);
        }

        public override void Area()
        {
            double area = A * b;
            Console.WriteLine("Area on the Rektangel = " + area);
        }
    }
}
