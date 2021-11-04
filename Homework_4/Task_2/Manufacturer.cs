using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4.Task_2
{
    class Manufacturer : Provider
    {
        List<Product> nomenclature;
        public List<Product> Nomenclature { get; private set; }
        public Manufacturer(long inn, string name,string adress)
        {
            INN = inn;
            Name = name;
            Adress = adress;
            Nomenclature = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            Nomenclature.Add(product);
        }
        public void AddProduct(long AN, string name, decimal price)
        {
            Nomenclature.Add(new Product(AN, name, price));
        }
    }
}
