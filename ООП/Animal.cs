namespace ООП;

public class Animal
{
    int rub;
    int kop;

    public int Rub
    {
        get => rub;
        set
        {
            if (value < 0)
            {
                rub = 0;
                Console.WriteLine("Рубли не могут быть отрицательными");
            }
            else
            {
                rub = value;
            }
        }

    }

    public int Kop
    {
        get => kop;
        set
        {
            if (value < 0)
            {
                rub = 0;
                Console.WriteLine("Копейки не могут быть отрицательными");
            }

            if (value > 99)
            {
                rub += value / 100;
                kop = value % 100;
            }
            else
            {
                rub = value;
            }
        }
    }

    public Animal(int rub, int kop)
    {
        Rub = rub;
        Kop = kop;
    }

    public void Show()
    {
        Console.WriteLine($"{rub}, {kop}");
    }
}