


namespace C;

public static class Circle
{
    public static double Radius{get; set;}
    public static double Pi {get; set;} = 3.14;

    public static double CalcCircleArea(double radius)
    {
        return Pi * (radius * radius);
    }

    public static double CalcCirclePerimeter(double radius)
    {
        return 2 * Pi * radius;
    } 
}