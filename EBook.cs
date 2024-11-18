using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp2
{
    public class EBook : Tech
    {
        private int charge;
        private int controlMethod;

        public int Charge
        {
            get => charge;
            set => charge = (value < 90 || value > 20000) ? 0 : value; // Валидация
        }

        public int ControlMethod
        {
            get => controlMethod;
            set => controlMethod = (value >= 0 || value <= 1) ? 0: value;
        }

        public EBook() : base()
        {
            Charge = 0;
            ControlMethod = 0;
        }

        public EBook(int charge, int controlMethod,int price, int weight) : base(price, weight)
        {
            Charge = charge;
            ControlMethod = controlMethod;
        }

        //Метод print
       
        public override string ToString()
        {
            if (ControlMethod == 0)
            {
                return $"{base.ToString()}Заряд батареи: {Charge}\nНаличие сенсорного управления: есть\n";
            }
            else
            {
                return $"{base.ToString()}Заряд батареи: {Charge}\nНаличие сенсорного управления: нет\n";
            }
        }
    }
}