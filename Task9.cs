// with ref parametres
using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input the coefficients of the quadratic equation (a, b, c):");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());
        double x1 = 0, x2 = 0;
        SolveQuadraticEquation(a, b, c, ref x1, ref x2);
        Console.WriteLine($"The solutions are: x1 = {x1}, x2 = {x2}");
    }
    public static void SolveQuadraticEquation(double a, double b, double c, ref double x1, ref double x2)
    {
        double discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            Console.WriteLine("The solutions are complex numbers.");
            return;
        }
        x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
    }
}
// with tuple
using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input the coefficients of the quadratic equation (a, b, c):");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());
        var solutions = SolveQuadraticEquation(a, b, c);
        Console.WriteLine($"The solutions are: x1 = {solutions.Item1}, x2 = {solutions.Item2}");
    }
    public static (double, double) SolveQuadraticEquation(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            Console.WriteLine("The solutions are complex numbers.");
            return (double.NaN, double.NaN);
        }
        double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        return (x1, x2);
    }
}

//with array
using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the coefficients of the quadratic equation (a, b, c):");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        var solutions = SolveQuadraticEquation(a, b, c);
        Console.WriteLine($"The solutions are: x1 = {solutions[0]}, x2 = {solutions[1]}");
    }
    public static double[] SolveQuadraticEquation(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            Console.WriteLine("The solutions are complex numbers.");
            return new double[] { double.NaN, double.NaN };
        }
        double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        return new double[] { x1, x2 };
    }
}

//with deconstructing
using System;
public class QuadraticSolution
{
    public double X1 { get; }
    public double X2 { get; }
    public QuadraticSolution(double x1, double x2)
    {
        X1 = x1;
        X2 = x2;
    }
    public void Deconstruct(out double x1, out double x2)
    {
        x1 = X1;
        x2 = X2;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the coefficients of the quadratic equation (a, b, c):");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());
        var solution = SolveQuadraticEquation(a, b, c);
        var (x1, x2) = solution;
        Console.WriteLine($"The solutions are: x1 = {x1}, x2 = {x2}");
    }
    public static QuadraticSolution SolveQuadraticEquation(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            Console.WriteLine("The solutions are complex numbers.");
            return new QuadraticSolution(double.NaN, double.NaN);
        }
        double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        return new QuadraticSolution(x1, x2);
    }
}