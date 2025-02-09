namespace ООП;
internal class Money
{
    public int rub;
    public int kop;

    public void Sum(int sum)
    {
        kop += sum;
    }

    public void Print()
    {
        Console.WriteLine($"{rub}, {kop}");
    }
}