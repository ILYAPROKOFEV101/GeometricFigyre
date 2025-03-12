namespace GeometricFigyre;

public class GeometricObject
{
    // Fields for position and color
    public double X { get; protected set; } // X-coordinate
    public double Y { get; protected set; } // Y-coordinate
    public string Color { get; protected set; } // Color of the object

    // Constructor to initialize position and color
    public GeometricObject(double x, double y, string color)
    {
        X = x;
        Y = y;
        Color = color;
    }

    // Default constructor (optional, if needed)
    public GeometricObject()
    {
        X = 0;
        Y = 0;
        Color = "White"; // Default color
    }

    // Method to display basic information about the geometric object
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Position: ({X}, {Y})");
        Console.WriteLine($"Color: {Color}");
    }
}
