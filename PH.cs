using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class PH : Tech
    {
        private int speed;
        private string tech;

        public int Speed
        {
            get => speed;
            set => speed = (value < 1 || value > 60) ? 0 : value; // Валидация
        }

        public PH(int speed, string tech, int price, int weight) : base(price, weight)
        {
            Speed = speed;
            this.tech = tech;
        }


        public override string ToString()
        {
            return $"{base.ToString()}Скорость запуска: {Speed}\nТип экрана: {tech}\n";
        }
    }
}
