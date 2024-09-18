// Bai tap cong ty


namespace Bai03;

public class Employee(string _name = "")
{
    public string Name { get; set; } = _name;
    //  public Employee(Employee prev) : this(prev.Name) { }
}

public class Company(string _name = "", List<Employee>? _employees = null)
{
    public string Name { get; set; } = _name;
    public List<Employee> Employees { get; set; } = _employees ?? [];

    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }

    public void Print()
    {
        Console.WriteLine($"Cong ty: {Name}");
        Console.WriteLine("Danh sach nhan vien:");
        foreach (var employee in Employees)
        {
            Console.WriteLine($"- {employee.Name}");
        }
    }

}

public class Program
{
    static void Main(string[] args)
    {
        Company company = new("Nitro Group", [new Employee("Nguyen Van A"), new Employee("Doan Thi B")]);
        company.AddEmployee(new Employee("Tran Van C"));
        company.Print();
    }
}