

namespace SharpChess.Core;

/// <summary>
/// Vector class with immutable integer coordinates.
/// </summary>
public sealed class Vec
{
    public readonly int X;
    public readonly int Y;

    public Vec(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Vec(int a)
    {
        X = a;
        Y = a;
    }

    public Vec(Vec a)
    {
        X = a.X;
        Y = a.Y;
    }

    // Invert y
    public Vec InvertY() => new(X, -Y);
    
    // Invert x
    public Vec InvertX() => new(-X, Y);
    
    // Plus operator
    public static Vec operator +(Vec a, Vec b) => new(a.X + b.X, a.Y + b.Y);

    // Minus operator
    public static Vec operator -(Vec a, Vec b) => new(a.X - b.X, a.Y - b.Y);

    // Scalar multiplication
    public static Vec operator *(Vec a, int b) => new(a.X * b, a.Y * b);
    // Other order, use above method
    public static Vec operator *(int a, Vec b) => b * a;
    /*
    // Scalar division
    public static Vec operator /(Vec a, int b) => new(a.X / b, a.Y / b);
    // Other order
    public static Vec operator /(int a, Vec b) => b / a;
    */
    
    // Implicit conversion from int
    
}