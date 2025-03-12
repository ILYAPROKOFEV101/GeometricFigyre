// See https://aka.ms/new-console-template for more information

using GeometricFigyre;

class Program
{
    static void Main(string[] args)
    {
        
        
        Triangle triangle = new Triangle(3, 4, 5, "Red", 0, 0);

        triangle.PrintInfo();
        triangle.Print("Red");
    }
}