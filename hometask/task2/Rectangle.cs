

namespace C;
public static class Rectangle
{
    public static double Length{get; set;}
    public static double Width{get; set;}

    public static double CalcRectangleArea(double length, double width)
    {
        return length * width;
    }

    public static double CalcRectanglePerimeter(double length, double width)
    {
        return 2 * ( length + width );
    }
}