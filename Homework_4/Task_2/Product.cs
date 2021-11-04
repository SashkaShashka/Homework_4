using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4.Task_2
{
    public class Product
    {
        public ArticleNumber ArticleNumber { get;set;}
        public string Name { get; private set; }
        private decimal price;
        public decimal Price { get => price; 
            set 
            {
                if (value < 0)
                    throw new ArgumentException("Цена не может быть меньше нуля");
                else
                    price = value;
            } 
        }
        public Product(ArticleNumber an, string name, decimal price)
        {
            ArticleNumber = an;
            Name = name;
            Price = price;
        }
        public Product(Product product) : this(product.ArticleNumber, product.Name, product.Price) { }
        public bool Equals(string s)
        {
            s = s.ToLower();
            return Name.ToLower().Contains(s) || ArticleNumber.Contains(s);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Название: " + Name + new string(' ', 10));
            sb.Append("Цена: " + string.Format("{0:C2}",Price));
            return sb.ToString();
        }

    }
}
