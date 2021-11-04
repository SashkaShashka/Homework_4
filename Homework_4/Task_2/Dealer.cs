using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4.Task_2
{
    class Dealer : Provider
    {
        public Manufacturer Manufacturer { get; private set; }
        private double percent;
        public double Percent
        {
            get
            {
                return percent;
            }
            set
            {
                if (value > 0 && value <= 100)
                    percent = value;
                else
                    throw new ArgumentException("Неверное значение процентов");
            }
        }
        public Dealer(INN inn, string name, string adress, double percent, Manufacturer man=null)
        {
            INN = inn;
            Name = name;
            Adress = adress;
            Percent = percent;
            if (man != null)
                Manufacturer = man;
        }
        public void SetManufacturer(Manufacturer man)
        {
            if (man != null && Manufacturer == null)
                Manufacturer = man;
        }
        public List<Product> Contains(string s)
        {
            List<Product> products = Manufacturer.Contains(s);
            foreach (var item in products)
            {
                item.Price *= (decimal)(100 + Percent) / 100;
            }
            return products;   
        }
    }
}
