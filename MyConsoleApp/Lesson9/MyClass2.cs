using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
    // Универсальные шаблоны. (Универсальный метод)
    public class MyClass2
    {
        public void Method<T>(T argument)
        {
            T variable = argument;

            Console.WriteLine(variable.ToString());
        }
    }
}
