using System;

namespace Lesson2
{
    class Program
    {
        /*
        -- Value Type (Типы значений / Значимые типы)
        Целочисленные типы (byte, sbyte, short, ushort, int, uint, long, ulong)
        Типы с плавающей запятой (float, double)
        Тип decimal
        Тип bool
        Тип char
        Перечисления enum
        Структуры (struct)

        -- Reference Type (Ссылочные типы)
        Тип object
        Тип string
        Классы (class)
        Интерфейсы (interface)
        Делегаты (delegate)

         */

        public interface IKeyValuePair
        {
            int MyKey { get; set; }
            string MyValue { get; set; }
        }

        public class SomeClass : IKeyValuePair
        {
            public int MyKey { get; set; }
            public string MyValue { get; set; }
        }

        enum Colors
        {
            Красный,
            Синий,
            Желтый,
            Серый
        };

        // Структуры
        struct MyStruct
        {
            int x;
        }

        // Классы
        class MyClass
        {
            // Приватное поле
            private int x;

            // Конструктор без параметров
            public MyClass()
            {
            }

            // Конструктор с парамтром int myValue
            public MyClass(int myValue)
            {
                x = myValue;
            }

            // Сеттер
            public void SetX(int myValue)
            {
                x = myValue;
            }

            // Геттер
            public int GetX()
            {
                return x;
            }

            // Метод который пишет значение в консоль
            public void ShowX()
            {
                Console.WriteLine(x);
            }
        }

        static void Main(string[] args)
        {
            // Значимые типы данных -----------------------------------------------------------------------

            // Целочисленные
            byte MyByte;     // System.Byte 
            sbyte SByte;
            short MyShort;
            ushort MyUShort;
            int MyInt;       // System.Int32 
            uint MyUint;
            long MyLong;     // System.Int64
            ulong MyULong;

            // Типы с плавающей точкой
            float MyFloat;
            double MyDouble; // +
            decimal MyDecimal; // +

            // Логические
            bool MyBool = false;

            // Символьные
            char MyChar;

            //Перечисление
            Colors colors = Colors.Красный;

            // Структура
            MyStruct myStruct = new MyStruct();


            // Ссылочные типы данных ------------------------------------------------------------------------------

            object MyObject = "Какой-то объект";

            // Строковые
            string MyString = "\"Собака\"";  //  символ \" - это экранирование "

            // Класс
            MyClass myClass = new MyClass();
            myClass.SetX(777);
            myClass.ShowX();

            Console.ReadKey();  
        }
    }
}
