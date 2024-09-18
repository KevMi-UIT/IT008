// 155

namespace Bai04;

public delegate void MethodDelegate();

public class Person
{
    public void Hello(MethodDelegate mDelegate)
    {
        Console.WriteLine("Hello Delegate");
        //Gọi Method được truyền vào
        mDelegate?.Invoke();
    }
}

class Program
{
    private static void priMethod()
    {
        Console.WriteLine("Private Method");
    }

    public static void Main(string[] args)
    {
        Person person = new();

        //Khai báo delegate trỏ tới privateMethod
        MethodDelegate helloDelegate = new(priMethod);

        //Truyền delegate vào method Hello như một đối

        person.Hello(helloDelegate);
    }
}
