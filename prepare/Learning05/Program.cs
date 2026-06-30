using System;

class Program {
    static void Main(string[] args) {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Orange", 3));
        shapes.Add(new Rectangle("Red", 2, 4));
        shapes.Add(new Circle("Blue", 3));

        foreach(Shape shape in shapes) {
            Console.WriteLine($"{shape.GetColor()} : {shape.GetArea()}");
        }
    }
}