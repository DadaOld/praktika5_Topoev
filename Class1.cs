using System;
using System.Collections.Generic;

// Перечисление типов экранов
public enum Screen
{
    LCD, // Экран LCD
    OLED, // Экран OLED
    Undefined // Неопределенный тип экрана
}

// Базовый класс для всех устройств
public class Tech
{
    private string firm;
    private int weight;
    private int price;

    public string Firm
    {
        get => firm;
        set => firm = string.IsNullOrEmpty(value) ? "Firm" : value;
    }

    public int Weight
    {
        get => weight;
        set
        {
            if (value < 1 || value > 20000)
                weight = 1000; // Устанавливаем значение по умолчанию
            else
                weight = value;
        }
    }

    public int Price
    {
        get => price;
        set
        {
            if (value < 100 || value > 1000000)
                price = 10000; // Устанавливаем значение по умолчанию
            else
                price = value;
        }
    }

    public Tech()
    {
        Firm = "";
        Weight = 1000;
        Price = 1000;
    }

    public Tech(string firm, int price, int weight)
    {
        Firm = firm;
        Price = price;
        Weight = weight;
    }

    public virtual void Print()
    {
        Console.WriteLine($"\nФирма: {Firm}\nЦена: {Price}\nВес: {Weight}");
    }
}

// Класс для смартфонов
public class PH : Tech
{
    private int speed;
    private Screen tech;

    public int Speed
    {
        get => speed;
        set => speed = (value < 1 || value > 60) ? 0 : value; // Валидация
    }

    public Screen Tech
    {
        get => tech;
        set => tech = value; // Здесь можно добавить валидацию, если нужно
    }

    public PH() : base()
    {
        Speed = 0;
        Tech = Screen.Undefined;
    }

    public PH(int speed, Screen tech, string firm, int price, int weight) : base(firm, price, weight)
    {
        Speed = speed;
        Tech = tech;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Скорость запуска: {Speed}\nТип экрана: {Tech}");
    }
}

// Класс для электронных книг
public class EBook : Tech
{
    private int charge;
    private bool controlMethod;

    public int Charge
    {
        get => charge;
        set => charge = (value < 90 || value > 20000) ? 0 : value; // Валидация
    }

    public bool ControlMethod
    {
        get => controlMethod;
        set => controlMethod = value;
    }

    public EBook() : base()
    {
        Charge = 0;
        ControlMethod = false;
    }

    public EBook(int charge, bool controlMethod, string firm, int price, int weight) : base(firm, price, weight)
    {
        Charge = charge;
        ControlMethod = controlMethod;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Заряд батареи: {Charge}\nНаличие сенсорного управления: {(ControlMethod ? "Есть" : "Отсутствует")}\n");
    }
}

// Основной класс программы
class Program
{
    // Основной метод программы
    static void Main(string[] args)
    {
        // Инициализация кодировки консоли
        Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);
        // Создание списка устройств
        List<Tech> a = new List<Tech>();
        // Основной цикл программы
        while (true)
        {
            // Ввод пользователя
            string str;
            int weight, price, speed, sv3, charge;

            Console.WriteLine("Ваш выбор:");
            int choice;
            Console.WriteLine("\n" + "1-ввод смартфона\n" + "2-ввод электронной книги\n" + "3-ввод устройства\n" + "4-вывод всех устройств\n" + "0-выход\n\n");
            choice = Convert.ToInt32(Console.ReadLine());
            // Обработка выбора пользователя
            switch (choice)
            {
                case 1:
                    // Ввод смартфона
                    Console.Write("Введите фирму: ");
                    str = Console.ReadLine();
                    Console.Write("Введите цену: ");
                    price = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите вес: ");
                    weight = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите время запуска: ");
                    speed = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите тип экрана: 1-LCD, 2-OLED: ");
                    sv3 = Convert.ToInt32(Console.ReadLine());
                    Screen sv4 = sv3 == 1 ? Screen.LCD : sv3 == 2 ? Screen.OLED : Screen.Undefined;
                    PH pri = new PH(speed, sv4, str, price, weight);
                    a.Add(pri);
                    break;
                case 2:
                    // Ввод электронной книги
                    Console.Write("Введите фирму: ");
                    str = Console.ReadLine();
                    Console.Write("Введите цену: ");
                    price = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите вес: ");
                    weight = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Заряд батареи: ");
                    charge = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Управление производится: 0 - кнопками, 1 - сенсором ");
                    sv3 = Convert.ToInt32(Console.ReadLine());
                    EBook rad = new EBook(charge, Convert.ToBoolean(sv3), str, price, weight);
                    a.Add(rad);
                    break;
                case 3:
                    // Ввод устройства
                    Console.Write("Введите фирму: ");
                    str = Console.ReadLine();
                    Console.Write("Введите цену: ");
                    price = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите вес: ");
                    weight = Convert.ToInt32(Console.ReadLine());
                    Tech tech = new Tech(str, price, weight);
                    a.Add(tech);
                    break;
                case 4:
                    // Вывод всех устройств
                    foreach (Tech item in a)
                    {
                        item.Print();
                    }
                    break;
                case 0:
                    // Выход из программы
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nНеверный выбор\n");
                    continue;
            }
        }
    }
}