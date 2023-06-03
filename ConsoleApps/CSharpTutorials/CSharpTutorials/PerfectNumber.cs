using System;

class PerfectNumber
{
    static void Main(string[] args)
    {
        int limit = 10000;

        Console.WriteLine("Mükemmel Sayılar:");
        for (int i = 1; i <= limit; i++)
        {
            if (IsPerfectNumber(i))
                Console.Write(i + " ");
        }
    }

    static bool IsPerfectNumber(int number)
    {
        int sum = 0;

        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
                sum += i;
        }

        return (sum == number);
    }
}
