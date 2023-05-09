using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Trapez : Square
    {
        private double b;
        private double c;
        private double d;
        private double h;

        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public double D
        {
            get { return d; }
            set { d = value; }
        }
      
        
        public Trapez(double a, double b,double c,double d) :base(a)
        {
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override void Area()
        {
            FindeHight();

            double area = 0.5 * (A+c) + h;

            Console.WriteLine("Trapez area = " + area);
        }

        public override void Perimeter()
        {
            double perimerter = A + b + c + d;
            Console.WriteLine("Perimeter on the trapez is " + perimerter);
        }

        private void FindeHight()
        {
            double s = (A+b-c+d)/2;

            h = 2/(A-c)*Math.Sqrt(s*(s-A+c)*(s-b)*(s-d));
        }



    }
}
