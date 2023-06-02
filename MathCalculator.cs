using System;

public class MathCalculator
{

    public void MathMax(int num1, int num2)
    {
        int max = Math.Max(num1, num2);
        Console.WriteLine("Max: " + max);
    }

    public void MathMin(int num1, int num2)
    {
        int min = Math.Min(num1, num2);
        Console.WriteLine("Min: " + min);
    }

    public void MathAbs(int num)
    {
        int absoluteValue = Math.Abs(num);
        Console.WriteLine("Absolute Value: " + absoluteValue);
    }

    public void MathRound(double number)
    {
        double roundedValue = Math.Round(number);
        Console.WriteLine("Rounded Value: " + roundedValue);
    }

    public void MathSqrt(double number)
    {
        double squareRoot = Math.Sqrt(number);
        Console.WriteLine("Square Root: " + squareRoot);
    }
}
