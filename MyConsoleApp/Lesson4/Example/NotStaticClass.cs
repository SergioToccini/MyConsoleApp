using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4.Example
{
    public sealed class NotStaticClass
    {
        public static int MyStaticField;
        // const относятся к типу , а не к экземляру типа
        // константы не могут быть статическими, по своему поведению они и так статические
        // доступны только для чтения
        public const int MyConstField = 777;

        public void MyMethod()
        {
            Console.WriteLine();
        }
    }
}
