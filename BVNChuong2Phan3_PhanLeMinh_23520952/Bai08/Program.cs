// 167

using System.Collections;

namespace Bai08;

public class Person
{
    public Person(string fName, string lName)
    {
        firstName = fName;
        lastName = lName;
    }

    public string firstName;
    public string lastName;
}

public class People : IEnumerable
{
    private Person[] _people;

    // Khởi tạo
    public People(Person[] pArray)
    {
        _people = new Person[pArray.Length];

        for (int i = 0; i < pArray.Length; i++)
        {
            _people[i] = pArray[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public PeopleEnum GetEnumerator()
    {
        return new PeopleEnum(_people);
    }
}

public class PeopleEnum : IEnumerator
{
    public Person[] _people;
    int position = -1;

    // Khởi tạo
    public PeopleEnum(Person[] list)
    {
        _people = list;
    }

    // Tăng vị trí
    public bool MoveNext()
    {
        position++;
        return (position < _people.Length);
    }

    public void Reset()
    {
        position = -1;
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public Person Current
    {
        get
        {
            try
            {
                return _people[position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
}

class Program
{
    public static void Main()
    {
        Person[] peopleArray = [
            new ("John", "Smith"),
            new ("Jim", "Johnson"),
            new ("Sue", "Rabon"),
        ];
        People peopleList = new(peopleArray);
        // liệt kê danh sách dùng foreach
        foreach (Person p in peopleList)
        {
            Console.WriteLine(p.firstName + " " + p.lastName);
        }
        PeopleEnum peopleEnum = peopleList.GetEnumerator();
        peopleEnum.Reset();
        // lấy người đầu tiên trong danh sách
        peopleEnum.MoveNext();
        Person firstPerson = peopleEnum.Current;
        Console.WriteLine("First Person: {0} {1}",
        firstPerson.firstName, firstPerson.lastName);
    }
}
