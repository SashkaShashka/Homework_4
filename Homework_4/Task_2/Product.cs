using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4.Task_2
{
    public class Product
    {
        public long ArticleNumber { 
            get
            {
                return ArticleNumber;
            }
            set
            {
                if (value.ToString().Length >= 10 && value.ToString().Length <= 15)
                    ArticleNumber = value;
                else throw new Exception("Недопустимое значение артикула");
            }
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product(long AN, string name, decimal price)
        {
            ArticleNumber = AN;
            Name = name;
            Price = price;
        }
    }
}
