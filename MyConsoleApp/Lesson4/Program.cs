using System;
using Lesson4.Example;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            NotStaticClass instanse1 = new NotStaticClass();
            NotStaticClass instanse2 = new NotStaticClass();

            NotStaticClass.MyStaticField = 1;
            NotStaticClass.MyStaticField = 5;

            NotStaticClass df = new NotStaticClass();

            StaticClass.MyStaticMethod();

            Console.WriteLine("Пишем в консоль и переводим каретку на новую строку");
            Console.Write("Пишем в консоль");


        }
    }
}
