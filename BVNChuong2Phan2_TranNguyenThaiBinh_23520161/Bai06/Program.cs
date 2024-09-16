// class in class

namespace Bai06;

public class Person(string _lastName = "", string _firstName = "")
{
    public class Date(int _day = 1, int _month = 1, int _year = 2000)
    {
        private int Day { get; set; } = _day;
        private int Month { get; set; } = _month;
        private int Year { get; set; } = _year;

        public void PrintDate()
        {
            Console.WriteLine($"{Day}/{Month}/{Year}");
        }
    }

    public string FirstName { get; private set; } = _firstName;
    public string LastName { get; private set; } = _lastName;
    private Date? DateOfBirth = null;

    public void SetDateOfBirth(int day, int month, int year)
    {
        DateOfBirth = new(day, month, year);
    }

    public void Print()
    {
        Console.WriteLine($"Ho va ten: {LastName} {FirstName}");
        if (DateOfBirth != null)
        {
            Console.Write("Ngay sinh: ");
            DateOfBirth.PrintDate();
        }
        else
        {
            Console.WriteLine("Chua co ngay sinh");
        }
    }
}

public class Program
{
    static void Main()
    {
        Person a = new("Duong Thi Yen", "Nhi");
        a.SetDateOfBirth(27, 9, 2005);
        a.Print();
    }
}
