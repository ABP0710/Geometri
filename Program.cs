namespace Geometri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //assignment a + b
            Square square1 = new Square(4);
            Square square2 = new Square(5);
            Square square3 = new Square(6);

            square1.Perimeter();
            square2.Perimeter();
            square3.Perimeter();

            square1.Area();
            square2.Area();
            square3.Area();

            //assignment c
            Rektangel rektangel1 = new Rektangel(3, 7);
            Rektangel rektangel2 = new Rektangel(4, 5);
            rektangel1.Perimeter();
            rektangel2.Perimeter();
            rektangel1.Area();
            rektangel2.Area();

            //assignment d
            Parallelogram parallelogram1 = new Parallelogram(3, 5, 20);
            parallelogram1.Perimeter();
            parallelogram1.Area();

            //assignment e
            Trapez trapez1 = new Trapez(10, 4, 5, 4);
            trapez1.Area();
            trapez1.Perimeter();

            //assignment f
            Triangle triangle = new Triangle(3, 4);
            triangle.Perimeter();
            triangle.Area();

            //assignment g
            List<Shape> shapes = new List<Shape>();
            shapes.Add(square1);
            shapes.Add(square2);
            shapes.Add(square3);
            shapes.Add(rektangel1);
            shapes.Add(rektangel2);
            shapes.Add(parallelogram1);
            shapes.Add(trapez1);
            shapes.Add(triangle);

            foreach (Shape item in shapes)
            {
                Console.WriteLine(item);
            }
        }
    }
}