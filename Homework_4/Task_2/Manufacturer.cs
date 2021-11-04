using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4.Task_2
{
    class Manufacturer : Provider
    {
        public List<Product> Nomenclature { get; private set; }
        public Manufacturer(INN inn, string name,string adress, List<Product> products=null)
        {
            INN = inn;
            Name = name;
            Adress = adress;
            Nomenclature = products ?? new List<Product>();
        }
        public void AddProduct(Product product)
        {
            Nomenclature.Add(product);
        }
        public void AddProduct(ArticleNumber AN, string name, decimal price)
        {
            Nomenclature.Add(new Product(AN, name, price));
        }
        public List<Product> Contains(string s)
        {
            List<Product> answer = new List<Product>();
            foreach (var item in Nomenclature)
            {
                if (item.Equals(s))
                    answer.Add(new Product(item));
            }
            return answer;
        }
    }
}
