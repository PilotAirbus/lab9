namespace ООП;

public class Конструктор_по_умолчанию
{
    public int age;
    public string name;

    public Конструктор_по_умолчанию()
    {
        age = 0;
        name = "ПУК ПУК";
    }

    public void Show()
    {
        Console.WriteLine($"{age}, {name}");
    }
    
    
}