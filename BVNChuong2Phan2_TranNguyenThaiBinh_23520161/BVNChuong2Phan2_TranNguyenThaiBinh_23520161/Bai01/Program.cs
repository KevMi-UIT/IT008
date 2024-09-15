// Date get only

namespace Bai01;

public class CDate(DateTime _cDate)
{
    public DateTime Date { get; } = _cDate;
}

public class Program
{
    static void Main(string[] args)
    {
        CDate cDate = new CDate(DateTime.Now);
        Console.WriteLine(cDate.Date);
    }
}
