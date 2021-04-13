using System;

namespace Lesson9
{
    // Универсальные шаблоны.
    class Program
    {
        static void Main(string[] args)
        {
            Generics1();
            Generics2();
            Generics3();

            // Delay.
            Console.ReadKey();
        }

        private static void Generics1()
        {
            // Создаем экземпляр класса MyClass и в качестве параметра типа (тип MyClass) передаем тип int.
            MyClass1<int> instance1 = new MyClass1<int>();
            instance1.Method();

            // Создаем экземпляр класса MyClass и в качестве параметра типа (тип MyClass) передаем тип long.
            MyClass1<long> instance2 = new MyClass1<long>();
            instance2.Method();

            // Создаем экземпляр класса MyClass и в качестве параметра типа (тип MyClass) передаем тип string.
            MyClass1<string> instance3 = new MyClass1<string>();
            instance3.field = "ABC";
            instance3.Method();
        }
        private static void Generics2()
        {
            MyGenerics<int, int> instance1 = new MyGenerics<int, int>(1, 2);
            Console.WriteLine(instance1.Variable1 + instance1.Variable2);

            MyGenerics<string, int> instance2 = new MyGenerics<string, int>("Number ", 1);
            Console.WriteLine(instance2.Variable1 + instance2.Variable2);

            MyGenerics<string, string> instance3 = new MyGenerics<string, string>("Hello ", "World");
            Console.WriteLine(instance3.Variable1 + instance3.Variable2);
        }
        private static void Generics3()
        {
            MyClass2 instance = new MyClass2();

            instance.Method<string>("Hello world!");

            instance.Method("Привет мир!");
        }

    }
}
