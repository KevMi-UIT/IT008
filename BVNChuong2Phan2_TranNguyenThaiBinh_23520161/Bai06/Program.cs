// class in class

namespace Bai06;

public class Person(string _lastName = "", string _firstName = "")
{
    public class Date
    {
        private int _day;
        private int _month;
        private int _year;
        public Date() { _day = 1; _month = 1; _year = 1; }
        public Date(int init_day, int init_month, int init_year)
        {
            this._day = init_day;
            this._month = init_month;
            this._year = init_year;
        }
        public void PrintDate()
        {
            Console.WriteLine($"{_day}/{_month}/{_year}");
        }
    }

    public string FirstName { get; set; } = _firstName;
    public string LastName { get; set; } = _lastName;
    private Date Date_of_Birth = new Date();
    public void setDateOfBirth(int day, int month, int year)
    {
        Date_of_Birth = new Date(day, month, year);
    }
    public void Print()
    {
        Console.WriteLine($"Ho va ten: {LastName} {FirstName}");
        Console.Write("Ngay sinh: ");
        Date_of_Birth.PrintDate();
    }
}

public class Program
{
    static void Main()
    {
        Person a = new Person("Nguyen Van", "B");
        a.setDateOfBirth(31, 12, 1999);
        a.Print();
    }
}
