using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4.Task_2
{
    abstract class Provider
    {
        public INN INN{ get; set; }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Название не может быть пустым");
                else
                    name = value;
            }
        }
        private string adress;
        public string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Название не может быть пустым");
                else
                    adress = value;
            }
        }
    }
}
