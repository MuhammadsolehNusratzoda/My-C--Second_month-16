
namespace C;
public static class Triangle
{
    public static double Base{get; set;}
    public static double Height{get; set;}

    public static double CalcTriangleArea(double basse, double height)
    {
        return 0.5 * ( basse * height );
    }

    public static double CalcTrianglePerimeter(double side1, double side2, double side3)
    {
        return side1 + side2 + side3;
    }
}