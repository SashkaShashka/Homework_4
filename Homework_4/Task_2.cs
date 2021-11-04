using System;
using System.Collections.Generic;
using Homework_4.Task_2;

namespace Homework_4
{
    class program
    {
        static List<Manufacturer> manufacturers = new List<Manufacturer>();
        static List<Dealer> dealers = new List<Dealer>();
        static void Inizialization()
        {
            manufacturers.Add(new Manufacturer(new INN("1212121212"), "Samara_Company", "Samara", new List<Product>()
            {
                new Product(new ArticleNumber("1111111111"),"Колбаса",59),
                new Product(new ArticleNumber("2222222222"),"Сосиски",189),
                new Product(new ArticleNumber("3333333333"),"Сыр",499),
                new Product(new ArticleNumber("4444444444"),"Молоко",79),
                new Product(new ArticleNumber("5555555555"),"Масло",119),
                new Product(new ArticleNumber("6666666666"),"Сыр деревенский",399),
                new Product(new ArticleNumber("7777777777"),"Сыр косичка",89),
                new Product(new ArticleNumber("8888888888"),"Сыр плавленный",69),
                new Product(new ArticleNumber("9999999999"),"Колбаса вареная",199),
                new Product(new ArticleNumber("1000000000"),"Колбаса новорусская",259)
            }
            ));
            manufacturers.Add(new Manufacturer(new INN("3434343434"), "Mosсow_Company", "Mosсow", new List<Product>()
            {
                new Product(new ArticleNumber("1000000000"),"Конфеты коровка",125),
                new Product(new ArticleNumber("2000000000"),"Шоколадные конфеты",190),
                new Product(new ArticleNumber("3000000000"),"Печенье",60),
                new Product(new ArticleNumber("4000000000"),"Халва",80),
                new Product(new ArticleNumber("5000000000"),"Халва в шоколаде",100),
                new Product(new ArticleNumber("6000000000"),"Овсяное печенье",130),
                new Product(new ArticleNumber("7000000000"),"Печенье К кофе",110),
                new Product(new ArticleNumber("8000000000"),"Конфеты бабаевские",450),
                new Product(new ArticleNumber("9000000000"),"Конфеты 35",250),
                new Product(new ArticleNumber("1000000000"),"Боярушка",700)
            }
            ));
            manufacturers.Add(new Manufacturer(new INN("5656565656"), "Kazan_Company", "Kazan", new List<Product>()
            {
                new Product(new ArticleNumber("1100000000"),"Шоколад Аленка",99),
                new Product(new ArticleNumber("2200000000"),"Шоколад с кокосом",59),
                new Product(new ArticleNumber("3300000000"),"Шоколад с изюмом",59),
                new Product(new ArticleNumber("4400000000"),"Шоколад с ягодами",59),
                new Product(new ArticleNumber("5500000000"),"Шоколад молочный",59),
                new Product(new ArticleNumber("6600000000"),"Шоколад темный",59),
                new Product(new ArticleNumber("7700000000"),"Шоколад белый",59),
                new Product(new ArticleNumber("9900000000"),"Шоколад milka",99),
                new Product(new ArticleNumber("8800000000"),"Шоколад с фундуком",59),
                new Product(new ArticleNumber("1200000000"),"Шоколад с миндалем",59)
            }
            ));
            manufacturers.Add(new Manufacturer(new INN("7878787878"), "Piter_Company", "Piter", new List<Product>()
            {
                new Product(new ArticleNumber("1111000000"),"Сок яблочный",79),
                new Product(new ArticleNumber("2222000000"),"Сок морковной",79),
                new Product(new ArticleNumber("3333000000"),"Сок грушевый",79),
                new Product(new ArticleNumber("4444000000"),"Сок земляника",79),
                new Product(new ArticleNumber("5555000000"),"Сок мультифрукт",79),
                new Product(new ArticleNumber("6666000000"),"Сок томатный",79),
                new Product(new ArticleNumber("7777000000"),"Сок апельсиновый",79),
                new Product(new ArticleNumber("8888000000"),"Сок ананасовый",79),
                new Product(new ArticleNumber("9999000000"),"Сок виноградный",79),
                new Product(new ArticleNumber("1234000000"),"Сок яблоко виноград",79)
            }
            ));
            manufacturers.Add(new Manufacturer(new INN("9090909090"), "Xiaomi_Company", "China", new List<Product>()
            {
                new Product(new ArticleNumber("1111122222"),"Xiaomi Mi A1",12999),
                new Product(new ArticleNumber("2222233333"),"MI 8",22999),
                new Product(new ArticleNumber("3333344444"),"MI 9",39999),
                new Product(new ArticleNumber("4444455555"),"MI 9 lite",29999),
                new Product(new ArticleNumber("5555566666"),"MI 10",49999),
                new Product(new ArticleNumber("6666677777"),"MI 10 PRO",59999),
                new Product(new ArticleNumber("7777788888"),"Redmi 7",9999),
                new Product(new ArticleNumber("8888899999"),"Redmi note 7",12999),
                new Product(new ArticleNumber("9999900000"),"Redmi note 7 pro",15999),
                new Product(new ArticleNumber("1111199999"),"Redmi 8 pro",15999)
            }
            ));
            
            dealers.Add(new Dealer(new INN("1234567890"), "Dealer_1", "Adress_1", 5, manufacturers[1]));
            dealers.Add(new Dealer(new INN("1234512345"), "Dealer_2", "Adress_2", 15, manufacturers[2]));
            dealers.Add(new Dealer(new INN("1357924680"), "Dealer_3", "Adress_3", 25, manufacturers[1]));
        }
        static void Find(string s)
        {
            bool isFind = false;
            foreach (var item in manufacturers)
            {
                List<Product> products= item.Contains(s);
                if (products.Count>0)
                {
                    isFind = true;
                    Console.WriteLine("Наименование: {0} Адрес: {1} Товары:", item.Name, item.Adress);
                    foreach (var product in products)
                    {
                        Console.WriteLine(product.ToString());
                    }
                    Console.WriteLine();
                }
            }
            foreach (var item in dealers)
            {
                List<Product> products = item.Contains(s);
                if (products.Count > 0)
                {
                    isFind = true;
                    Console.WriteLine("Наименование: {0} Адрес: {1} (Поставщик: {2}) Товары:", item.Name, item.Adress,item.Manufacturer.Name);
                    foreach (var product in products)
                    {
                        Console.WriteLine(product.ToString());
                    }
                    Console.WriteLine();
                }
            }
            if (!isFind)
                Console.WriteLine("Совпадений не найдено!");
        }
        static void Main(string[] args)
        {
            // Запуск Task_2
            Inizialization();
            Console.Write("Введите строку для поиска: ");
            Find(Console.ReadLine());
        }
    }
}
