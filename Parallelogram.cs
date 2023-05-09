using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geometri
{
    public class Parallelogram : Rektangel
    {
        private double angle;

        public double Angle
        {
            get { return angle; }
            set { angle = value; }
        }

        public Parallelogram(double a, double b, double angle) : base(a, b)
        {
            this.angle = angle;
        }

        public override void Perimeter()
        {
            double perimeter = 2 * (A + B);

            Console.WriteLine("Perimeter on the parallelogram = " + perimeter);
        }

        public override void Area()
        {
            double area = A * B * Math.Sin(angle);

            Console.WriteLine("Area on the parallelogram = " + area);

        }
    }
}
