using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4.Task_2
{
    public class ArticleNumber
    {
        public string PartNumber { get; private set; }

        public ArticleNumber(string AN)
        {
            for (int i = 0; i < AN.ToString().Length; i++)
            {
                if (!(AN[i] <= '9' && AN[i] >= '0'))
                    throw new ArgumentException("Неправильный формат аргумента");
            }

            if (AN.Length >= 10 && AN.Length <= 15)
                PartNumber = AN;
            else throw new Exception("Номер должен состоять из 10-15 цифр");
        }
        public bool Contains(string s)
        {
            return PartNumber.Contains(s);
        }
    }
}
