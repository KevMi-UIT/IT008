namespace Bai02;
public class CustomSearcher
{
    public static List<string> GetDirectories(string path, string searchPattern = "*",
        SearchOption searchOption = SearchOption.AllDirectories)
    {
        if (searchOption == SearchOption.TopDirectoryOnly)
            return Directory.GetDirectories(path, searchPattern).ToList();

        var directories = new List<string>(GetDirectories(path, searchPattern));

        for (var i = 0; i < directories.Count; i++)
            directories.AddRange(GetDirectories(directories[i], searchPattern));

        return directories;
    }

    private static List<string> GetDirectories(string path, string searchPattern)
    {
        try
        {
            return Directory.GetDirectories(path, searchPattern).ToList();
        }
        catch (UnauthorizedAccessException)
        {
            return new List<string>();
        }
    }
    public static void EnumerateFile(string path)
    {
        foreach (var dir in GetDirectories(path))
        {
            string[] fileEntries = Directory.GetFiles(dir);
            Console.WriteLine($"Files in Directory: {dir} ");
            foreach (string fileName in fileEntries)
                Console.WriteLine($"\t|-----{fileName}");
            Console.WriteLine();
        }
    }
    public override string ToString()
    {
        return base.ToString() ?? "";
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input the Directory path: ");
        string path = Console.ReadLine() ?? "";
        var dir = CustomSearcher.GetDirectories(path);
        Console.WriteLine($"\nAll {dir.Count} subdirectories: ");
        Console.WriteLine(string.Join("\n", dir));
        Console.WriteLine("-------------------------------------------");
        CustomSearcher.EnumerateFile(path);
    }
}
