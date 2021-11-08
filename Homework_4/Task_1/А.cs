using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4
{
    abstract class A
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
            throw new NotImplementedException();
        }
        public abstract void Foo(DateTime dateTime);
    }
}
