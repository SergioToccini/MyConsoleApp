using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{

    // На 9-й строке создаем класс с именем MyClass1, параметризированный Указателем Места Заполнения Типом - T
    public class MyClass1<T>
    {
        public T field;

        public void Method()
        {
            Console.WriteLine(field.GetType());
        }
    }
}
