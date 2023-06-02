using System;
using System.IO;

public class FileHandler
{
    public void FileReadAllText(string filePath)
    {
        string content = File.ReadAllText(filePath);
        Console.WriteLine("File Content: " + content);
    }

    public void FileWriteAllText(string filePath, string content)
    {
        File.WriteAllText(filePath, content);
        Console.WriteLine("File written successfully!");
    }

    public void DirectoryCreate(string directoryPath)
    {
        Directory.CreateDirectory(directoryPath);
        Console.WriteLine("Directory created successfully!");
    }

    public void DirectoryGetFiles(string directoryPath)
    {
        string[] files = Directory.GetFiles(directoryPath);
        Console.WriteLine("Files in the directory:");
        foreach (string file in files)
        {
            Console.WriteLine(file);
        }
    }

    public void DirectoryDelete(string directoryPath)
    {
        Directory.Delete(directoryPath);
        Console.WriteLine("Directory deleted successfully!");
    }

}
