using MetodosAbstrados.Èntities;

namespace metodos {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            List<Shape> shapes = new List<Shape>();

            for (int i = 1; i <= n; i++) {
                Console.Write("Rectangle or Circle (r/c)? ");
                char r = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red):");

                if( r == 'r') {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    shapes.Add(new Rectangle(width, height, Color.Black));
                } else {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(radius, Color.Blue));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape shape in shapes) {
                Console.WriteLine(shape.Area());
            }
        }
    }
}