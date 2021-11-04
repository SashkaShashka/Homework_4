using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4.Task_2
{
    class Dealer : Provider
    {
        private Manufacturer manufacturer = null;
        public Manufacturer Manufacturer { get; private set; }
        public float Procent
        {
            get
            {
                return Procent;
            }
            set
            {
                if (value > 0 && value <= 100)
                    Procent = value;
                else
                    throw new ArgumentException("Неверное значение процентов");
            }
        }
        public Dealer(long inn, string name,string adress, Manufacturer man=null)
        {
            INN = inn;
            Name = name;
            Adress = adress;
            if (man != null)
                Manufacturer = man;
        }
        public void SetManufacturer(Manufacturer man)
        {
            if (man != null && Manufacturer == null)
                Manufacturer = man;
        }
    }
}
