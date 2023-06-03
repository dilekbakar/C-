using System;

class Fibonacci
{
    static void Main(string[] args)
    {
        int n = 10; 

        Console.WriteLine("Fibonacci Dizisi:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
