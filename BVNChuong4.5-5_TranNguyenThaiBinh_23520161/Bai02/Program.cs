// 147

namespace Bai02;

public class Person
{
    public void Swim()
    {
        Console.WriteLine("Person is swimming");
    }
}

public class Duck
{
    public void Swim()
    {
        Console.WriteLine("The Duck is swimming");
    }
}

public class Program
{
    //Hàm có paramater là một object dynamic
    public static void InvokeSwim(dynamic obj)
    {
        obj.Swim();
    }

    public static void Main(string[] args)
    {
        //Khai báo 2 object dynamic khác nhau
        dynamic person = new Person();
        dynamic duck = new Duck();
        //Truyền 2 object khác kiểu vào cùng 1 hàm
        InvokeSwim(person);
        InvokeSwim(duck);
    }
}
