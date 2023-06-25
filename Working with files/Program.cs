// See https://aka.ms/new-console-template for more information
using System.Dynamic;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Good Job");

FileService.DirCreateagain();
FileService.WriteFile("Good job");

public static class FileService
{
    static string dirname = "Papka";
    static FileService()
    {
    }
    //public static string file = "file";
    //public static void DirCreate()
    //{
    //    if (!Directory.Exists(@$"D:\{dirname}"))
    //    {
    //        Directory.CreateDirectory(@$"D:\{dirname}");
    //    }
        
    //    for (int i = 0; i < 10; i++)
    //    {
    //        string path = Path.Combine(@$"D:\{dirname}", $"{i}.txt");
    //        Console.WriteLine(path);
    //        using (FileStream fs = File.Create(path))
    //        { }
    //    }
    //}
    public static void WriteFile(string text)
    {

        string yol = Directory.GetCurrentDirectory();
        yol=Path.Combine(yol, dirname);
        foreach (string file in Directory.GetFiles(yol))
        {
            using (StreamWriter writer = new StreamWriter(file, true))
            {
                writer.WriteLine(text);
            }
        }
    }
    public static void DirCreateagain()
    {
        string newpath = "";
        string path = $"{Directory.GetCurrentDirectory}\\{dirname}";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        for (int i = 0; i < 10; i++)
        {
            newpath = Path.Combine(path, $"{i}.txt");
            using (FileStream fs = File.Create(newpath))
            { }
        }
    }
}
