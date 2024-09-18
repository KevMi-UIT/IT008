public class CDate
{
    public CDate() { }
    private int day; private int month; private int year;
    private static readonly int[] DaysInMonthLeap = [0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
    private static readonly int[] DaysInMonthNoLeap = [0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
    public void Input()
    {
        Console.Write("Nhap ngay: ");
        this.day = int.Parse(Console.ReadLine() ?? "1");
        Console.Write("Nhap thang: ");
        this.month = int.Parse(Console.ReadLine() ?? "1");
        Console.Write("Nhap nam: ");
        this.year = int.Parse(Console.ReadLine() ?? "1");
    }
    private static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
    }
    public bool CheckDay()
    {
        return IsLeapYear(this.year) ? (this.day >= 1 && this.day <= DaysInMonthLeap[this.month]) :
    (this.day >= 1 && this.day <= DaysInMonthNoLeap[this.month]);
    }
    public bool CheckValid()
    {
        if (this.year < 0 || (this.month <= 0 || this.month > 12))
            return false;
        return CheckDay();
    }

    public DateTime GetDateTime()
    {
        return new DateTime(year, month, day);
    }
    public void DateOfWeek()
    {
        Console.WriteLine(GetDateTime().ToString("dddd"));
    }
}

public class Program
{
    static void Main(string[] args)
    {
        CDate date = new CDate();
        date.Input();
        if (date.CheckValid())
            date.DateOfWeek();
        else Console.WriteLine("Ngay thang nam khong hop le.");
    }
}
