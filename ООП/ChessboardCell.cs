namespace ООП;

public class ChessboardCell
{
    #region 1часть
    public enum Color //Используем перечисляемый типа - enum для считывания увета
    {
        black,
        white
    }
    
    public int horizontal;//Поля(переменные)
    public int vertical;
    static int count;
    public Color color;
    
    public int Horizontal//Свойства для числа Horizontal
    {
        get => horizontal;
        set
        {
            if (value < 1 || value > 8)
            {
                throw new Exception("Выход за пределы ограничений (число от 1 до 8)");
            }
            else
            {
                horizontal = value;
            }
        }
    }

    public int Vertical//Свойства для числа Vertical
    {
        get => vertical;
        set
        {
            if (value < 1 || value > 8)
            {
                throw new Exception("Выход за пределы ограничений (число от 1 до 8)");
            }
            else
            {
                vertical = value;
            }
        }
    }

    public ChessboardCell()//Конструктор по умолчанию
    {
        Random rand = new Random();
        Horizontal = rand.Next(1, 8);
        Vertical = rand.Next(1, 8);//(ДЛЯ 6 КЕЙСА ВРУЧНУЮ 5 ПОСТАВЬ)!!!!!!!!!!!!!!!!!!!
        count++;
    }
    
    public ChessboardCell(ChessboardCell cell)//Конструктор с параметром
    {
        Horizontal = cell.Horizontal;
        Vertical = cell.Vertical;
        if ((Horizontal + Vertical) % 2 == 0)
        {
            color = Color.black;
        }
        else
        {
            color = Color.white;
        }
        count++;
    }
    
    public ChessboardCell(int horizontal, int vertical, Color color)//Конструктор с параметрами
    {
        Horizontal = horizontal;
        Vertical = vertical;
        if ((Horizontal + Vertical) % 2 == 0)
        {
            this.color = Color.black;
        }
        else
        {
            this.color = Color.white;
        }
        count++;
    }
    public static int GetCount() => count;//Функция для подсчета количества объектов

    public string Show()//Функция для вывода на консоль
    {
        return $"Вертикаль: {Vertical}, горизонталь: {Horizontal}, цвет: {color}";
    }

    public static bool ColorComparison1(ChessboardCell cell1, ChessboardCell cell2)//Статическая функция для сравнения цвета клеток
    {
        if (cell1.color == cell2.color)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool ColorComparison2(ChessboardCell cell1, ChessboardCell cell2)//Метод класса для сравнения цвета клеток
    {
        if (cell1.color == cell2.color)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    #endregion
    
    public static ChessboardCell operator ++(ChessboardCell cell)//Перегрузка унарной операции (инкремент)
    {
        cell.Horizontal++;
        cell.Vertical++;
        return cell;
    }

    public static ChessboardCell operator !(ChessboardCell cell)//Перегрузка операции (смена клеток)
    {
        
        if (cell.Horizontal != cell.Vertical)
        {
            return new ChessboardCell(9 - cell.Vertical, 9 - cell.Horizontal, Color.black);
        }
        return cell;
    }
    //Явное преобразование(сумма координат клетки)
    public static explicit operator int(ChessboardCell cell)
    {
        return cell.Horizontal + cell.Vertical;
    }
    //Неявное преобразование(цвет клетки)
    public static implicit operator string(ChessboardCell cell)
    {
        if ((cell.Horizontal + cell.Vertical) % 2 == 0)
        {
            return Color.black.ToString();
        }
        else
        {
            return Color.white.ToString();
        }
    }
    //Бинарные операции (сравнение)#1
    public static bool operator == (ChessboardCell cell1, ChessboardCell cell2)
    {
        int deltaX = Math.Abs(cell1.Horizontal - cell2.Horizontal);
        int deltaY = Math.Abs(cell1.Vertical - cell2.Vertical);
        return (deltaX == 2 && deltaY == 1) || (deltaX == 1 && deltaY == 2);
    }
    
    //Бинарные операции (сравнение)#2
    public static bool operator != (ChessboardCell cell1, ChessboardCell cell2)
    {
        return cell1.Vertical != cell2.Vertical;
    }
    //Функция сравнения объектов (Equals)
    public override bool Equals(object obj)         
    {
        ChessboardCell cell = obj as ChessboardCell;
        if (cell == null)
        {
            return false;
        }
        return (Horizontal == cell.Horizontal && Vertical == cell.Vertical);
    }
}