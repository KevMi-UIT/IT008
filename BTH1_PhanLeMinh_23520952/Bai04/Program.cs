namespace Bai04;

public class Program
{
    private static readonly int[] DateLeap = [31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
    private static readonly int[] DateNoLeap = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];

    private static bool CheckLeap(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    static void Main(string[] args)
    {
        int month = int.Parse(Console.ReadLine() ?? "");
        int year = int.Parse(Console.ReadLine() ?? "");
        if (CheckLeap(year))
        {
            Console.WriteLine($"Thang {month} nam {year} co {DateLeap[month - 1]} ngay");
        }
        else
        {
            Console.WriteLine($"Thang {month} nam {year} co {DateNoLeap[month - 1]} ngay");
        }

    }
}
