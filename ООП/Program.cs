using System.Dynamic;
using System.Formats.Asn1;

namespace ООП;

class Program
{
    #region 1часть

    static public void FirstStage()
    {
        try
        {
            ChessboardCell a0 = new ChessboardCell(); //Конструктор по умолчанию
            ChessboardCell a1 = new ChessboardCell(a0); //Конструктор с параметром
            ChessboardCell a2 = new ChessboardCell(5, 5, ChessboardCell.Color.black); //Конструктор с параметрами
            Console.WriteLine(a1.Show());
            Console.WriteLine(a2.Show());
            Console.WriteLine($"Количество объектов: {ChessboardCell.GetCount()}"); //Вывод колиества объектов
            Console.WriteLine("Цвета клеток одинаковы?: " + ChessboardCell.ColorComparison1(a1, a2)); //Цвет клеток #1
            Console.WriteLine("Цвета клеток одинаковы?: " + a1.ColorComparison2(a1, a2)); //Цвет клеток #2

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    #endregion

    #region 2часть
    static public void SecondStage()
    {
        
        int answer2;//Переменная для второго меню
        Console.WriteLine("==========================");
        do
        {   //Проверка числа на ввод
            bool isChecked;
            do
            {
                Console.WriteLine("Введите число");
                isChecked = int.TryParse(Console.ReadLine(), out answer2);
                if (answer2 < 1 || answer2 > 7)
                {
                    Console.WriteLine("Неверный пункт меню!");
                    isChecked = false;
                }
                else if (!isChecked)
                {
                    Console.WriteLine("Ошибка ввода");
                }
            } while (!isChecked);
            //Вторая часть программы
            switch (answer2)
            {
                //Перегрузка унарной операции (инкремент)
                case 1:
                    ChessboardCell a0 = new ChessboardCell();
                    ChessboardCell a3 = new ChessboardCell(a0);
                    ChessboardCell a4 = new ChessboardCell(5, 5, ChessboardCell.Color.black);
                    a3++;
                    a4++;
                    Console.WriteLine("Первая фигурва: " + a3.Show());
                    Console.WriteLine("Вторая фигурва: " + a4.Show());
                    Console.WriteLine("==========================");
                    break;
                //Перегрузка операции (смена клеток)
                case 2:
                    ChessboardCell a5 = new ChessboardCell();
                    ChessboardCell a6 = new ChessboardCell(5, 8, ChessboardCell.Color.black);
                    ChessboardCell a7 = !a5;
                    ChessboardCell a8 = !a6;
                    Console.WriteLine(a7.Show());
                    Console.WriteLine(a8.Show());
                    Console.WriteLine("==========================");
                    break;
                //Явное преобразование(сумма координат клетки)
                case 3:
                    ChessboardCell a9 = new ChessboardCell();
                    ChessboardCell a10 = new ChessboardCell(5, 5, ChessboardCell.Color.black);
                    Console.WriteLine("Явное преобразование первого объекта = " + (int)a9);
                    Console.WriteLine("Явное преобразование второго объекта = " + (int)a10);
                    Console.WriteLine("==========================");
                    break;
                //Неявное преобразование(цвет клетки)
                case 4:
                    ChessboardCell a11 = new ChessboardCell();
                    ChessboardCell a12 = new ChessboardCell(5, 5, ChessboardCell.Color.black);
                    Console.WriteLine("Цвет клетки: " + a11);
                    Console.WriteLine("Цвет клетки: " + a12);
                    Console.WriteLine("==========================");
                    break;
                //Бинарные операции (сравнение)#1
                case 5:
                    ChessboardCell a13 = new ChessboardCell();
                    ChessboardCell a14 = new ChessboardCell(5, 5, ChessboardCell.Color.black);
                    Console.WriteLine($"Перемещение коня: {a13 == a14}");
                    Console.WriteLine("==========================");
                    break;
                //Бинарные операции (сравнение)#2
                case 6:
                    ChessboardCell a15 = new ChessboardCell();
                    ChessboardCell a16 = new ChessboardCell(5, 5, ChessboardCell.Color.black);
                    Console.WriteLine($"Фигуры находятся на разных вертикалях доски? {a15 != a16}");
                    Console.WriteLine("==========================");
                    break;
                 //Функция сравнения объектов (Equals)
                case 7:
                    ChessboardCell a17 = new ChessboardCell();
                    ChessboardCell a18 = new ChessboardCell(5, 5, ChessboardCell.Color.black);
                    Console.WriteLine(a17.Equals(a18));
                    break;
                case 8:
                     Console.WriteLine("Завершение работы");
                     break;
            }

        } while (answer2 < 8);
    }
    #endregion

    static void Main(string[] args)
    {
        FirstStage();
        SecondStage();

    }
}