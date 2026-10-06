using System;

class Circle
{
    public const double PI = 3.14;

    public static double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }

    public static double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}