// Date set only

namespace Bai02;

public class CDate(DateTime _cDate)
{
    public DateTime Date { private get; set; } = _cDate;
}

public class Program
{
    static void Main(string[] args)
    {
        CDate cDate = new CDate(DateTime.Now);
        Thread.Sleep(1000);
        cDate.Date = DateTime.Now;
    }
}
