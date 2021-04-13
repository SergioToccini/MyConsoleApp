using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
    public class MyGenerics<TYPE1, TYPE2>
    {
        // Поля
        private TYPE1 variable1;
        private TYPE2 variable2;

        // Конструктор.
        public MyGenerics(TYPE1 argument1, TYPE2 argument2)
        {
            this.variable1 = argument1;
            this.variable2 = argument2;
        }

        // Свойства.
        public TYPE1 Variable1
        {
            get { return this.variable1; }
            set { this.variable1 = value; }
        }

        public TYPE2 Variable2
        {
            get { return this.variable2; }
            set { this.variable2 = value; }
        }
    }
}
