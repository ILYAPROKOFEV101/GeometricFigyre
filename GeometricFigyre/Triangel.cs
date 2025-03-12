using System.Drawing;

namespace GeometricFigyre;

public class Triangle : GeometricObject
{
    // стороны треугольника 
    public double A { get; private set; }
    public double B { get; private set; }
    public double C { get; private set; }

    
    public double XB { get; private set; }
    public double YB { get; private set; }
    public double XC { get; private set; }
    public double YC { get; private set; }

    public Triangle(double a, double b, double c, string color, double x, double y)
        : base(x, y, color) 
    {
        A = a;
        B = b;
        C = c;
        FindCoordinates(); 
    }

 
    public bool IsExist()
    {
        return (A + B > C) && (A + C > B) && (B + C > A); // <button class="citation-flag" data-index="7">
    }

    public void FindCoordinates()
    {
        if (!IsExist())
            throw new InvalidOperationException("Triangle cannot exist with given side lengths");

       
        XB = X + C; 
        YB = Y;

       
        double deltaX = (Math.Pow(C, 2) + Math.Pow(B, 2) - Math.Pow(A, 2)) / (2 * C);
        XC = X + deltaX;
        double deltaY = Math.Sqrt(Math.Pow(B, 2) - Math.Pow(deltaX, 2));
        YC = Y + deltaY; 
    }

    // Написанть информацию о треуголнки 
    public void Print(string message)
    {
        Console.WriteLine(message);
        Console.WriteLine($"Вертикаль A: ({X}, {Y})");
        Console.WriteLine($"Вертикаль B: ({XB}, {YB})");
        Console.WriteLine($"Вертикаль C: ({XC}, {YC})");
        Console.WriteLine($"Сторона: A={A}, B={B}, C={C}");
        Console.WriteLine($"Цвет: {typeof(Color)}");
    }
}