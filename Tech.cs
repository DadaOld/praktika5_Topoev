using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public enum Screen
    {
        LCD, // Экран LCD
        OLED, // Экран OLED
        Undefined // Неопределенный тип экрана
    }
    public class Tech
    {
        private int weight;
        private int price;


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
            Weight = 1000;
            Price = 1000;
        }

        public Tech(int price, int weight)
        {
            Price = price;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Вес:{weight}\nЦена (Руб.):{price}\n";
        }
    }
}
