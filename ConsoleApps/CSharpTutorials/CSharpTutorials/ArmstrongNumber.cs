using System;

class ArmstrongNumber
{
    static void Main(string[] args)
    {
        int number = 153;

        if (IsArmstrongNumber(number))
            Console.WriteLine(number + " bir Armstrong sayısıdır.");
        else
            Console.WriteLine(number + " bir Armstrong sayısı değildir.");
    }

    static bool IsArmstrongNumber(int number)
    {
        int sum = 0;
        int temp = number;
        int digitCount = GetDigitCount(number);

        while (temp != 0)
        {
            int remainder = temp % 10;
            sum += (int)Math.Pow(remainder, digitCount);
            temp /= 10;
        }

        return (sum == number);
    }

    static int GetDigitCount(int number)
    {
        int count = 0;
        while (number != 0)
        {
            count++;
            number /= 10;
        }

        return count;
    }
}
