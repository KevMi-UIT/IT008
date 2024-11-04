// 157

namespace Bai05;

delegate void MethodDelegate();

public class Person
{
    public void Hello()
    {
        Console.WriteLine("Hello Delegate");
    }

    public void Swim()
    {
        Console.WriteLine("Person is swimming");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        MethodDelegate multicastDelegate = null;

        //Multicasting delegate
        multicastDelegate += new MethodDelegate(person.Hello);
        multicastDelegate += new MethodDelegate(person.Swim);
        multicastDelegate();
    }
}

