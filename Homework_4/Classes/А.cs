using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4
{
    public abstract class А
    {
        public string Prop1 = "aaa";
        public int Prop2
        {
            get => Prop2;
            set
            {
                if (value <= 100 && value >= 0)
                    Prop2 = value;
            }
        }
        public int Foo()
        {
            return 0;
        }
        public void Foo(DateTime dateTime)
        {

        }
    }
}
