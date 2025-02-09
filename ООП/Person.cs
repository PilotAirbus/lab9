namespace ООП;

public class Person
{
    public string name;
    public int age;

    public Person(string myName, int myAge)
    {
        name = myName;
        age = myAge;
    }

    public Person()
    {
        name = "NoName";
        age = 20;
    }

    public Person(Person p)
    {
        this.name = p.name;
        this.age = p.age;
    }

    public void Show()
    {
        Console.WriteLine($"{name}, {age}");
    }
}