using System;

public class StringManipulator
{
    public static string[] SplitString(string input, char delimiter)
    {
        return input.Split(delimiter);
    }

    public static string JoinStrings(string[] inputArray, string separator)
    {
        return string.Join(separator, inputArray);
    }

    public static bool IsNullOrEmpty(string input)
    {
        return string.IsNullOrEmpty(input);
    }
    public void StringLength(string text)
    {
        int length = text.Length;
        Console.WriteLine("Length: " + length);
    }

    public void StringConcatenation(string str1, string str2)
    {
        string result = str1 + str2;
        Console.WriteLine("Concatenated String: " + result);
    }

    public void StringSubstring(string text, int startIndex, int length)
    {
        string substring = text.Substring(startIndex, length);
        Console.WriteLine("Substring: " + substring);
    }

    public void StringToLower(string text)
    {
        string lowerCase = text.ToLower();
        Console.WriteLine("Lowercase: " + lowerCase);
    }

    public void StringToUpper(string text)
    {
        string upperCase = text.ToUpper();
        Console.WriteLine("Uppercase: " + upperCase);
    }
}
