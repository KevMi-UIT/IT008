// Indexer

namespace Bai03;

public class Subject(string _name = "", int score = 0)
{
    public string Name { get; private set; } = _name;
    public int Score { get; set; } = score;
}

public class Student(string _name, List<Subject> _marks)
{
    public string Name { get; private set; } = _name;

    public int this[string subject]
    {
        get
        {
            var mark = _marks.FirstOrDefault(m => m.Name == subject);
            return mark?.Score ?? 0;
        }
        set
        {
            var mark = _marks.FirstOrDefault(m => m.Name == subject);
            if (mark != null)
            {
                mark.Score = value;
            }
            else
            {
                _marks.Add(new Subject(subject, value));
            }
        }
    }
}

class Program
{

    static void Main()
    {
        Student student = new("Binh",
        [
            new ("Toan", 10),
            new ("Ly", 9),
            new ("Hoa", 8),
        ]);

        student["Toan"] = 9;
        student["Van"] = 7;

        Console.WriteLine($"Diem Toan: {student["Toan"]}");
        Console.WriteLine($"Diem Ly: {student["Ly"]}");
        Console.WriteLine($"Diem Hoa: {student["Hoa"]}");
        Console.WriteLine($"Diem Van: {student["Van"]}");
        Console.WriteLine($"Diem Sinh: {student["Sinh"]}"); // 0
    }
}
