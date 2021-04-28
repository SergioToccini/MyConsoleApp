using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Lesson7.Pattern;
using Microsoft.VisualBasic;

namespace Lesson7
{
    class Program
    {
        /*

        public interface IEnumerable 
        { 
            IEnumerator GetEnumerator(); // Итератор
        }
        
        // https://refactoring.guru/ru/design-patterns/iterator
        public interface IEnumerator // Итератор
        {
            bool MoveNext();         // Перемещает итератор к следующему элементу коллекции
            object? Current { get; } // Получаем текущий элемент коллекции
            void Reset();            // Устанавливает итератор в изначальное положение перед первым элементом коллекции
        }

        // Выгоден при перечислении объектов. Итератор будет работать быстрее, чем возвращаемая коллекция. Да и накладные расходы памяти ниже;
        IEnumerable<int> MultipleYieldReturn(IEnumerable<int> items)
        {
            foreach (var item in items)
                yield return item * item;
        }

         */



        static void Main(string[] args)
        {
            //IteratorExample();
            //Collection0Example();
            //Collection1Example();
            //Collection2Example();
            //Collection3Example();
            //Collection4Example();
        }


        static void IteratorExample()
        {
            IterableCollection collection = new ConcreteCollection();

            collection[0] = "Element A";
            collection[1] = "Element B";
            collection[2] = "Element C";
            collection[3] = "Element D";

            IIterator iterator = collection.CreateIterator();

            Console.WriteLine("Первый элемент коллекции:");

            object element = iterator.First();
            Console.WriteLine(element);

            Console.WriteLine(new string('-', 25));

            Console.WriteLine("Итерация по коллекции:");
            
            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.MoveNext());
            }
        }
        // Создание простой пользовательской коллекции.
        static void Collection0Example()
        {
            var сollection = new UserCollection0();

            сollection[0] = new Element(1, 2);
            сollection[1] = new Element(3, 4);
            сollection[2] = new Element(5, 6);
            сollection[3] = new Element(7, 8);

            foreach (Element element in сollection)
            {
                Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);
            }
        }
        // Создание простой пользовательской коллекции.
        static void Collection1Example()
        {
            var сollection = new UserCollection1();

            сollection[0] = new Element(1, 2);
            сollection[1] = new Element(3, 4);
            сollection[2] = new Element(5, 6);
            сollection[3] = new Element(7, 8);

            foreach (Element element in сollection)
            {
                Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);
            }

            Console.WriteLine(new string('-', 5));

            foreach (Element element in сollection)
            {
                Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);
            }

            Console.WriteLine(new string('-', 5));


            // element - переменная итерации

            // Так работает foreach
            IEnumerator enumerator = (сollection as IEnumerable).GetEnumerator();

            while (enumerator.MoveNext())
            {
                Element element = enumerator.Current as Element;

                Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);
            }
        }
        // Создание простой пользовательской коллекции с использованием обобщенных интерфейсов.
        static void Collection2Example()
        {
            var сollection = new UserCollection2<ElementXXX>();

            сollection[0] = new ElementXXX(1, 2);
            сollection[1] = new ElementXXX(3, 4);
            сollection[2] = new ElementXXX(5, 6);
            сollection[3] = new ElementXXX(7, 8);

            foreach (var element in сollection)
            {
                Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);
            }

            Console.WriteLine(new string('-', 5));

            foreach (var element in сollection)
            {
                Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);
            }
        }
        // Создание простой пользовательской коллекции с использованием оператора yield.
        static void Collection3Example()
        {
            var сollection = new UserCollection3<Element>();

            сollection[0] = new Element(1, 2);
            сollection[1] = new Element(3, 4);
            сollection[2] = new Element(5, 6);
            сollection[3] = new Element(7, 8);

            foreach (Element element in сollection)
            {
                Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);
            }

            Console.WriteLine(new string('-', 5));

            foreach (Element element in сollection)
            {
                Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);
            }
        }
        // Создание простой пользовательской коллекции с явной реализацией функций оператора yield.
        static void Collection4Example()
        {
            var сollection = new UserCollection4<Element>();

            сollection[0] = new Element(1, 2);
            сollection[1] = new Element(3, 4);
            сollection[2] = new Element(5, 6);
            сollection[3] = new Element(7, 8);

            foreach (Element element in сollection)
            {
                Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);
            }

            Console.WriteLine(new string('-', 5));

            foreach (Element element in сollection)
            {
                Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);
            }
        }
    }
}
