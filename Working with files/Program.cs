// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Hello, World!");

FileService.DirCreate("papka");
FileService.WriteFile("papka", "Hello world");

public static class FileService
{
    static FileService()
    {
    }
    public static string file = "file";
    public static void DirCreate(string dirname)
    {
        if (!Directory.Exists(@$"D:\{dirname}"))
        {
            Directory.CreateDirectory(@$"D:\{dirname}");
        }
        
        for (int i = 0; i < 10; i++)
        {
            string path = Path.Combine(@$"D:\{dirname}", file+$"{i}"+".txt");
            Console.WriteLine(path);
            using (FileStream fs = File.Create(path))
            { }
        }
    }
    public static void WriteFile(string dirname, string text)
    {
        foreach (string file in Directory.GetFiles(@$"D:\{dirname}"))
        {
            using (StreamWriter writer = new StreamWriter(file, true))
            {
                writer.WriteLine(text);
            }
        }
    }
}
