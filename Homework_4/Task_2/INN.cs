using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4.Task_2
{
    class INN
    {
        public string Inn { get; private set; }

        public INN(string inn)
        {
            for (int i = 0; i < inn.ToString().Length; i++)
            {
                if (!(inn[i] <= '9' && inn[i] >= '0'))
                    throw new ArgumentException("Неправильный формат аргумента");
            }

            if (inn.Length == 10)
                Inn = inn;
            else throw new Exception("ИНН должен состоять из 10 цифр");
        }
        
    }
}
