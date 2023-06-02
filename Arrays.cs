using System.Collections.Generic;
using System;

public class Arrays()
{
    public void CreateAndAccessArray()
    {
        int[] numbers = new int[5];

        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        numbers[3] = 4;
        numbers[4] = 5;

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Number at index " + i + ": " + numbers[i]);
        }
    }

    public void ArrayOperations()
    {
        string[] names = { "John", "Jane", "Alice", "Bob" };

        Console.WriteLine("Reversed Names:");
        for (int i = names.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(names[i]);
        }

        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine("Sum of numbers: " + sum);

        Array.Sort(numbers);
        Console.WriteLine("Sorted numbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    public void MultiDimensionalArray()
    {
        int[,] matrix = new int[3, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Matrix:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}