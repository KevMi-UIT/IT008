// 190

using System.Collections;
namespace Bai09;
public class Employee(int employeeId)
{

    private int empID { get; set; } = employeeId;
    public override string ToString()
    {
        return empID.ToString();
    }
}
class Program
{
    static void Main(string[] args)
    {
        ArrayList empArray = new ArrayList();
        ArrayList intArray = new ArrayList();
        // đưa vào mảng
        for (int i = 0; i < 5; i++)
        {
            empArray.Add(new Employee(i + 100));
            intArray.Add(new Employee(i * 5));
        }
        // in tất cả nội dung của intArray
        for (int i = 0; i < intArray.Count; i++)
        {
            Console.Write("{0} ", intArray[i]?.ToString());
        }
        Console.WriteLine("\n");
        // in tất cả nội dung của empArray
        for (int i = 0; i < empArray.Count; i++)
        {
            Console.Write("{0} ", empArray[i]?.ToString());
        }
        Console.WriteLine("\n");
        Console.WriteLine("empArray.Count: {0}", empArray.Count);
        Console.WriteLine("empArray.Capacity: {0}", empArray.Capacity);
    }
}

